﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tasks_lab_3.ServiceReference5 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Service1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Blogpost", Namespace="http://schemas.datacontract.org/2004/07/Service1")]
    [System.SerializableAttribute()]
    public partial class Blogpost : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PostApprovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostTitleField;
        
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
        public bool PostApproved {
            get {
                return this.PostApprovedField;
            }
            set {
                if ((this.PostApprovedField.Equals(value) != true)) {
                    this.PostApprovedField = value;
                    this.RaisePropertyChanged("PostApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostDescription {
            get {
                return this.PostDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.PostDescriptionField, value) != true)) {
                    this.PostDescriptionField = value;
                    this.RaisePropertyChanged("PostDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostTitle {
            get {
                return this.PostTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.PostTitleField, value) != true)) {
                    this.PostTitleField = value;
                    this.RaisePropertyChanged("PostTitle");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference5.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        tasks_lab_3.ServiceReference5.CompositeType GetDataUsingDataContract(tasks_lab_3.ServiceReference5.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<tasks_lab_3.ServiceReference5.CompositeType> GetDataUsingDataContractAsync(tasks_lab_3.ServiceReference5.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPost", ReplyAction="http://tempuri.org/IService1/getPostResponse")]
        tasks_lab_3.ServiceReference5.Blogpost getPost(int PostID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPost", ReplyAction="http://tempuri.org/IService1/getPostResponse")]
        System.Threading.Tasks.Task<tasks_lab_3.ServiceReference5.Blogpost> getPostAsync(int PostID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPostlist", ReplyAction="http://tempuri.org/IService1/getPostlistResponse")]
        tasks_lab_3.ServiceReference5.Blogpost[] getPostlist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPostlist", ReplyAction="http://tempuri.org/IService1/getPostlistResponse")]
        System.Threading.Tasks.Task<tasks_lab_3.ServiceReference5.Blogpost[]> getPostlistAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPost", ReplyAction="http://tempuri.org/IService1/addPostResponse")]
        void addPost(tasks_lab_3.ServiceReference5.Blogpost post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPost", ReplyAction="http://tempuri.org/IService1/addPostResponse")]
        System.Threading.Tasks.Task addPostAsync(tasks_lab_3.ServiceReference5.Blogpost post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deletepost", ReplyAction="http://tempuri.org/IService1/DeletepostResponse")]
        void Deletepost(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deletepost", ReplyAction="http://tempuri.org/IService1/DeletepostResponse")]
        System.Threading.Tasks.Task DeletepostAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/savepost", ReplyAction="http://tempuri.org/IService1/savepostResponse")]
        void savepost(tasks_lab_3.ServiceReference5.Blogpost post, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/savepost", ReplyAction="http://tempuri.org/IService1/savepostResponse")]
        System.Threading.Tasks.Task savepostAsync(tasks_lab_3.ServiceReference5.Blogpost post, int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : tasks_lab_3.ServiceReference5.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<tasks_lab_3.ServiceReference5.IService1>, tasks_lab_3.ServiceReference5.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public tasks_lab_3.ServiceReference5.CompositeType GetDataUsingDataContract(tasks_lab_3.ServiceReference5.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<tasks_lab_3.ServiceReference5.CompositeType> GetDataUsingDataContractAsync(tasks_lab_3.ServiceReference5.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public tasks_lab_3.ServiceReference5.Blogpost getPost(int PostID) {
            return base.Channel.getPost(PostID);
        }
        
        public System.Threading.Tasks.Task<tasks_lab_3.ServiceReference5.Blogpost> getPostAsync(int PostID) {
            return base.Channel.getPostAsync(PostID);
        }
        
        public tasks_lab_3.ServiceReference5.Blogpost[] getPostlist() {
            return base.Channel.getPostlist();
        }
        
        public System.Threading.Tasks.Task<tasks_lab_3.ServiceReference5.Blogpost[]> getPostlistAsync() {
            return base.Channel.getPostlistAsync();
        }
        
        public void addPost(tasks_lab_3.ServiceReference5.Blogpost post) {
            base.Channel.addPost(post);
        }
        
        public System.Threading.Tasks.Task addPostAsync(tasks_lab_3.ServiceReference5.Blogpost post) {
            return base.Channel.addPostAsync(post);
        }
        
        public void Deletepost(int a) {
            base.Channel.Deletepost(a);
        }
        
        public System.Threading.Tasks.Task DeletepostAsync(int a) {
            return base.Channel.DeletepostAsync(a);
        }
        
        public void savepost(tasks_lab_3.ServiceReference5.Blogpost post, int index) {
            base.Channel.savepost(post, index);
        }
        
        public System.Threading.Tasks.Task savepostAsync(tasks_lab_3.ServiceReference5.Blogpost post, int index) {
            return base.Channel.savepostAsync(post, index);
        }
    }
}
