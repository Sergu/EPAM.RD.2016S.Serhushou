﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using DAL.SearchCriterias;
using DAL.Repositories;
using BLL.Validators;
using DAL.Entities;
using BLL.Mappers;
using DAL.Exceptions;
using System.Threading;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace BLL.Services
{
    public class MasterService : MarshalByRefObject, IService<UserBll>
    {
        public readonly IRepository<UserEntity> repository;
        private IValidator<UserBll> userValidator;
        private IFileRepository<SavedEntity> fileRepository;
        private bool isLogged = false;
        private List<EndPointAddress> adresses;
        private ReaderWriterLockSlim readerWriterLock = new ReaderWriterLockSlim();

        public MasterService(IRepository<UserEntity> repository,IValidator<UserBll> validator,IFileRepository<SavedEntity> fileRepository,IEnumerable<EndPointAddress> adresses,bool isLogged)
        {
            this.isLogged = isLogged;
            this.adresses = new List<EndPointAddress>(adresses);
            this.repository = repository;
            this.userValidator = validator;
            this.fileRepository = fileRepository;
            SavedEntity savedState = new SavedEntity();
            try
            {
                savedState = fileRepository.GetState();
            }catch(XmlException ex)
            {
                savedState.Users = new List<UserEntity>();

                savedState.GeneratorPosition = 0;
            }
            this.repository.Update(savedState);
            if (this.isLogged)
                BllLogger.Instance.Trace("master service created. domain: " + AppDomain.CurrentDomain.FriendlyName);
        }

        public int Add(UserBll entity)
        {
            if (userValidator.Validate(entity))
            {
                int userId;
                UserBll user;
                try
                {
                    readerWriterLock.EnterWriteLock();
                    userId = repository.Add(entity.ToUserEntity());
                    user = repository.GetById(userId).ToBllUser();
                }
                finally
                {
                    readerWriterLock.ExitWriteLock();
                }
                if (isLogged)
                    BllLogger.Instance.Trace("master service add user with id : {0}", user.Id);
                var message = new Message { operation = Operation.add, param = user };
                NotifySlavesByNet(message);
                return userId;
            }
            else
            {
                if (isLogged)
                    BllLogger.Instance.Error("master service : invalid user format");
                throw new Exception();
            }
        }
        public void Delete(int id)
        {
            try
            {
                readerWriterLock.EnterWriteLock();
                repository.Delete(id);
            }
            finally
            {
                readerWriterLock.ExitWriteLock();
            }
            if (isLogged)
                BllLogger.Instance.Trace("master service : delete user : {0}", id);
            var message = new Message { operation = Operation.remove, param = id };
            NotifySlavesByNet(message);
        }
        private void NotifySlavesByNet(Message message)
        {
            if(message.operation == Operation.add)
                if (isLogged)
                    BllLogger.Instance.Trace("master service : notify slaves to add user with id : {0}", ((UserBll)message.param).Id);
            if(message.operation == Operation.remove)
                if (isLogged)
                    BllLogger.Instance.Trace("master service : notify slaves to remove user with id : {0}", ((int)message.param));
            foreach (var address in adresses)
            {
                TcpClient client = new TcpClient(address.address, address.port);
                NetworkStream networkStream = null;
                try
                {
                    var formatter = new BinaryFormatter();
                    networkStream = client.GetStream();
                    formatter.Serialize(networkStream, message);
                }
                finally
                {
                    networkStream.Close();
                }
            }
        }

        public IEnumerable<UserBll> Search(ISearchCriteria criteria)
        {
            List<UserBll> searchResult = new List<UserBll>();
            try
            {
                readerWriterLock.EnterReadLock();
                searchResult = new List<UserBll>(repository.Search(criteria).Select(user => user.ToBllUser()));
            }
            finally
            {
                readerWriterLock.ExitReadLock();
            }
            if (isLogged)
                BllLogger.Instance.Trace("master service searched {0} users", searchResult.Count());
            return searchResult;
        }
        public void SaveServiceState()
        {
            var savedState = repository.GetSavedState();

            if (isLogged)
                BllLogger.Instance.Trace("master service save state : users {0} , generator {1}", savedState.Users.Count,savedState.GeneratorPosition);
            fileRepository.SaveState(savedState);
        }
        public void UpdateServiceState()
        {
            SavedEntity entity = null;
            try
            {
                entity = fileRepository.GetState();
            }
            catch (XmlException)
            {
                entity.Users = new List<UserEntity>();
                entity.GeneratorPosition = 0;
            }
            if (isLogged)
                BllLogger.Instance.Trace("master service update state : users {0} , generator {1}", entity.Users.Count, entity.GeneratorPosition);
            repository.Update(entity);
        }
    }
}
