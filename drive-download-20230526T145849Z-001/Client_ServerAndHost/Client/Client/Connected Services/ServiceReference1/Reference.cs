﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Record", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.ServiceReference1.Galamb))]
    public partial class Record : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IDField;
        
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
        public System.Nullable<int> ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Galamb", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class Galamb : Client.ServiceReference1.Record {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte EletkorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FajtaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GazdaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte LabakSzamaField;
        
        private System.Nullable<bool> NemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NevField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Eletkor {
            get {
                return this.EletkorField;
            }
            set {
                if ((this.EletkorField.Equals(value) != true)) {
                    this.EletkorField = value;
                    this.RaisePropertyChanged("Eletkor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fajta {
            get {
                return this.FajtaField;
            }
            set {
                if ((object.ReferenceEquals(this.FajtaField, value) != true)) {
                    this.FajtaField = value;
                    this.RaisePropertyChanged("Fajta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gazda {
            get {
                return this.GazdaField;
            }
            set {
                if ((object.ReferenceEquals(this.GazdaField, value) != true)) {
                    this.GazdaField = value;
                    this.RaisePropertyChanged("Gazda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte LabakSzama {
            get {
                return this.LabakSzamaField;
            }
            set {
                if ((this.LabakSzamaField.Equals(value) != true)) {
                    this.LabakSzamaField = value;
                    this.RaisePropertyChanged("LabakSzama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<bool> Nem {
            get {
                return this.NemField;
            }
            set {
                if ((this.NemField.Equals(value) != true)) {
                    this.NemField = value;
                    this.RaisePropertyChanged("Nem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nev {
            get {
                return this.NevField;
            }
            set {
                if ((object.ReferenceEquals(this.NevField, value) != true)) {
                    this.NevField = value;
                    this.RaisePropertyChanged("Nev");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambGet", ReplyAction="http://tempuri.org/IService1/EgyGalambGetResponse")]
        Client.ServiceReference1.Galamb EgyGalambGet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambGet", ReplyAction="http://tempuri.org/IService1/EgyGalambGetResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambGetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambGetCS", ReplyAction="http://tempuri.org/IService1/EgyGalambGetCSResponse")]
        Client.ServiceReference1.Galamb EgyGalambGetCS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambGetCS", ReplyAction="http://tempuri.org/IService1/EgyGalambGetCSResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambGetCSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambPostCS", ReplyAction="http://tempuri.org/IService1/EgyGalambPostCSResponse")]
        Client.ServiceReference1.Galamb EgyGalambPostCS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambPostCS", ReplyAction="http://tempuri.org/IService1/EgyGalambPostCSResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambPostCSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambPost", ReplyAction="http://tempuri.org/IService1/EgyGalambPostResponse")]
        Client.ServiceReference1.Galamb EgyGalambPost();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EgyGalambPost", ReplyAction="http://tempuri.org/IService1/EgyGalambPostResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambPostAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambLista", ReplyAction="http://tempuri.org/IService1/GalambListaResponse")]
        Client.ServiceReference1.Galamb[] GalambLista();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambLista", ReplyAction="http://tempuri.org/IService1/GalambListaResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb[]> GalambListaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambListaCS", ReplyAction="http://tempuri.org/IService1/GalambListaCSResponse")]
        Client.ServiceReference1.Galamb[] GalambListaCS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambListaCS", ReplyAction="http://tempuri.org/IService1/GalambListaCSResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb[]> GalambListaCSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPost", ReplyAction="http://tempuri.org/IService1/GalambPostResponse")]
        string GalambPost(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPost", ReplyAction="http://tempuri.org/IService1/GalambPostResponse")]
        System.Threading.Tasks.Task<string> GalambPostAsync(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPostCS", ReplyAction="http://tempuri.org/IService1/GalambPostCSResponse")]
        string GalambPostCS(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPostCS", ReplyAction="http://tempuri.org/IService1/GalambPostCSResponse")]
        System.Threading.Tasks.Task<string> GalambPostCSAsync(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPut", ReplyAction="http://tempuri.org/IService1/GalambPutResponse")]
        string GalambPut(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPut", ReplyAction="http://tempuri.org/IService1/GalambPutResponse")]
        System.Threading.Tasks.Task<string> GalambPutAsync(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPutCS", ReplyAction="http://tempuri.org/IService1/GalambPutCSResponse")]
        string GalambPutCS(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambPutCS", ReplyAction="http://tempuri.org/IService1/GalambPutCSResponse")]
        System.Threading.Tasks.Task<string> GalambPutCSAsync(Client.ServiceReference1.Galamb galamb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambDelete", ReplyAction="http://tempuri.org/IService1/GalambDeleteResponse")]
        string GalambDelete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambDelete", ReplyAction="http://tempuri.org/IService1/GalambDeleteResponse")]
        System.Threading.Tasks.Task<string> GalambDeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambDeleteCS", ReplyAction="http://tempuri.org/IService1/GalambDeleteCSResponse")]
        string GalambDeleteCS(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambDeleteCS", ReplyAction="http://tempuri.org/IService1/GalambDeleteCSResponse")]
        System.Threading.Tasks.Task<string> GalambDeleteCSAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambDeleteParameter", ReplyAction="http://tempuri.org/IService1/GalambDeleteParameterResponse")]
        string GalambDeleteParameter(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambDeleteParameter", ReplyAction="http://tempuri.org/IService1/GalambDeleteParameterResponse")]
        System.Threading.Tasks.Task<string> GalambDeleteParameterAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambGetID", ReplyAction="http://tempuri.org/IService1/GalambGetIDResponse")]
        Client.ServiceReference1.Galamb GalambGetID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambGetID", ReplyAction="http://tempuri.org/IService1/GalambGetIDResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> GalambGetIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambGetIDCS", ReplyAction="http://tempuri.org/IService1/GalambGetIDCSResponse")]
        Client.ServiceReference1.Galamb GalambGetIDCS(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GalambGetIDCS", ReplyAction="http://tempuri.org/IService1/GalambGetIDCSResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> GalambGetIDCSAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ServiceReference1.Galamb EgyGalambGet() {
            return base.Channel.EgyGalambGet();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambGetAsync() {
            return base.Channel.EgyGalambGetAsync();
        }
        
        public Client.ServiceReference1.Galamb EgyGalambGetCS() {
            return base.Channel.EgyGalambGetCS();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambGetCSAsync() {
            return base.Channel.EgyGalambGetCSAsync();
        }
        
        public Client.ServiceReference1.Galamb EgyGalambPostCS() {
            return base.Channel.EgyGalambPostCS();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambPostCSAsync() {
            return base.Channel.EgyGalambPostCSAsync();
        }
        
        public Client.ServiceReference1.Galamb EgyGalambPost() {
            return base.Channel.EgyGalambPost();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> EgyGalambPostAsync() {
            return base.Channel.EgyGalambPostAsync();
        }
        
        public Client.ServiceReference1.Galamb[] GalambLista() {
            return base.Channel.GalambLista();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb[]> GalambListaAsync() {
            return base.Channel.GalambListaAsync();
        }
        
        public Client.ServiceReference1.Galamb[] GalambListaCS() {
            return base.Channel.GalambListaCS();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb[]> GalambListaCSAsync() {
            return base.Channel.GalambListaCSAsync();
        }
        
        public string GalambPost(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPost(galamb);
        }
        
        public System.Threading.Tasks.Task<string> GalambPostAsync(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPostAsync(galamb);
        }
        
        public string GalambPostCS(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPostCS(galamb);
        }
        
        public System.Threading.Tasks.Task<string> GalambPostCSAsync(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPostCSAsync(galamb);
        }
        
        public string GalambPut(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPut(galamb);
        }
        
        public System.Threading.Tasks.Task<string> GalambPutAsync(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPutAsync(galamb);
        }
        
        public string GalambPutCS(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPutCS(galamb);
        }
        
        public System.Threading.Tasks.Task<string> GalambPutCSAsync(Client.ServiceReference1.Galamb galamb) {
            return base.Channel.GalambPutCSAsync(galamb);
        }
        
        public string GalambDelete(int id) {
            return base.Channel.GalambDelete(id);
        }
        
        public System.Threading.Tasks.Task<string> GalambDeleteAsync(int id) {
            return base.Channel.GalambDeleteAsync(id);
        }
        
        public string GalambDeleteCS(int id) {
            return base.Channel.GalambDeleteCS(id);
        }
        
        public System.Threading.Tasks.Task<string> GalambDeleteCSAsync(int id) {
            return base.Channel.GalambDeleteCSAsync(id);
        }
        
        public string GalambDeleteParameter(int id) {
            return base.Channel.GalambDeleteParameter(id);
        }
        
        public System.Threading.Tasks.Task<string> GalambDeleteParameterAsync(int id) {
            return base.Channel.GalambDeleteParameterAsync(id);
        }
        
        public Client.ServiceReference1.Galamb GalambGetID(int id) {
            return base.Channel.GalambGetID(id);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> GalambGetIDAsync(int id) {
            return base.Channel.GalambGetIDAsync(id);
        }
        
        public Client.ServiceReference1.Galamb GalambGetIDCS(int id) {
            return base.Channel.GalambGetIDCS(id);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Galamb> GalambGetIDCSAsync(int id) {
            return base.Channel.GalambGetIDCSAsync(id);
        }
    }
}