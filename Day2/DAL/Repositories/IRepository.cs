﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.SearchCriterias;

namespace DAL.Repositories
{
    public interface IRepository<T>
    {
        int Add(T entity);
        void Delete(int id);
        IEnumerable<T> Search(ISearchCriteria criteria);
        SavedEntity GetSavedState();
        void Update(SavedEntity entity);
    }
}