﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.UserStorageServ {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserBll", Namespace="http://schemas.datacontract.org/2004/07/BLL.Entities")]
    [System.SerializableAttribute()]
    public partial class UserBll : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfClient.UserStorageServ.UserGender GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfClient.UserStorageServ.VisaRecord[] VisaRecordsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfClient.UserStorageServ.UserGender Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfClient.UserStorageServ.VisaRecord[] VisaRecords {
            get {
                return this.VisaRecordsField;
            }
            set {
                if ((object.ReferenceEquals(this.VisaRecordsField, value) != true)) {
                    this.VisaRecordsField = value;
                    this.RaisePropertyChanged("VisaRecords");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserGender", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entities")]
    public enum UserGender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        male = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        female = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VisaRecord", Namespace="http://schemas.datacontract.org/2004/07/DAL.Entities")]
    [System.SerializableAttribute()]
    public partial struct VisaRecord : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Countryk__BackingFieldField;
        
        private System.DateTime EndDatek__BackingFieldField;
        
        private System.DateTime StartDatek__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Country>k__BackingField", IsRequired=true)]
        public string Countryk__BackingField {
            get {
                return this.Countryk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Countryk__BackingFieldField, value) != true)) {
                    this.Countryk__BackingFieldField = value;
                    this.RaisePropertyChanged("Countryk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<EndDate>k__BackingField", IsRequired=true)]
        public System.DateTime EndDatek__BackingField {
            get {
                return this.EndDatek__BackingFieldField;
            }
            set {
                if ((this.EndDatek__BackingFieldField.Equals(value) != true)) {
                    this.EndDatek__BackingFieldField = value;
                    this.RaisePropertyChanged("EndDatek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<StartDate>k__BackingField", IsRequired=true)]
        public System.DateTime StartDatek__BackingField {
            get {
                return this.StartDatek__BackingFieldField;
            }
            set {
                if ((this.StartDatek__BackingFieldField.Equals(value) != true)) {
                    this.StartDatek__BackingFieldField = value;
                    this.RaisePropertyChanged("StartDatek__BackingField");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FirstNameCriteria", Namespace="http://schemas.datacontract.org/2004/07/DAL.SearchCriterias")]
    [System.SerializableAttribute()]
    public partial class FirstNameCriteria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LastNameCriteria", Namespace="http://schemas.datacontract.org/2004/07/DAL.SearchCriterias")]
    [System.SerializableAttribute()]
    public partial class LastNameCriteria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VisaCriteria", Namespace="http://schemas.datacontract.org/2004/07/DAL.SearchCriterias")]
    [System.SerializableAttribute()]
    public partial class VisaCriteria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfClient.UserStorageServ.VisaRecord visaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WcfClient.UserStorageServ.VisaRecord visa {
            get {
                return this.visaField;
            }
            set {
                if ((this.visaField.Equals(value) != true)) {
                    this.visaField = value;
                    this.RaisePropertyChanged("visa");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserStorageServ.IUserStorageService")]
    public interface IUserStorageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserStorageService/Add", ReplyAction="http://tempuri.org/IUserStorageService/AddResponse")]
        int Add(WcfClient.UserStorageServ.UserBll user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserStorageService/Add", ReplyAction="http://tempuri.org/IUserStorageService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(WcfClient.UserStorageServ.UserBll user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserStorageService/Delete", ReplyAction="http://tempuri.org/IUserStorageService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserStorageService/Delete", ReplyAction="http://tempuri.org/IUserStorageService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserStorageService/Search", ReplyAction="http://tempuri.org/IUserStorageService/SearchResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.VisaRecord))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.UserGender))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.VisaRecord[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.FirstNameCriteria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.LastNameCriteria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.VisaCriteria))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.UserBll))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WcfClient.UserStorageServ.UserBll[]))]
        WcfClient.UserStorageServ.UserBll[] Search(object criteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserStorageService/Search", ReplyAction="http://tempuri.org/IUserStorageService/SearchResponse")]
        System.Threading.Tasks.Task<WcfClient.UserStorageServ.UserBll[]> SearchAsync(object criteria);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserStorageServiceChannel : WcfClient.UserStorageServ.IUserStorageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserStorageServiceClient : System.ServiceModel.ClientBase<WcfClient.UserStorageServ.IUserStorageService>, WcfClient.UserStorageServ.IUserStorageService {
        
        public UserStorageServiceClient() {
        }
        
        public UserStorageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserStorageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserStorageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserStorageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(WcfClient.UserStorageServ.UserBll user) {
            return base.Channel.Add(user);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(WcfClient.UserStorageServ.UserBll user) {
            return base.Channel.AddAsync(user);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public WcfClient.UserStorageServ.UserBll[] Search(object criteria) {
            return base.Channel.Search(criteria);
        }
        
        public System.Threading.Tasks.Task<WcfClient.UserStorageServ.UserBll[]> SearchAsync(object criteria) {
            return base.Channel.SearchAsync(criteria);
        }
    }
}