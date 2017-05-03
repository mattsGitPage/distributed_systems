﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://venus.eas.asu.edu/WSRepository/Services/", ConfigurationName="ServiceReference1.ServiceSoap")]
    public interface ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://venus.eas.asu.edu/WSRepository/Services/Encrypt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Encrypt(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://venus.eas.asu.edu/WSRepository/Services/Encrypt", ReplyAction="*")]
        System.Threading.Tasks.Task<string> EncryptAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://venus.eas.asu.edu/WSRepository/Services/Decrypt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Decrypt(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://venus.eas.asu.edu/WSRepository/Services/Decrypt", ReplyAction="*")]
        System.Threading.Tasks.Task<string> DecryptAsync(string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : ClassLibrary1.ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<ClassLibrary1.ServiceReference1.ServiceSoap>, ClassLibrary1.ServiceReference1.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Encrypt(string text) {
            return base.Channel.Encrypt(text);
        }
        
        public System.Threading.Tasks.Task<string> EncryptAsync(string text) {
            return base.Channel.EncryptAsync(text);
        }
        
        public string Decrypt(string text) {
            return base.Channel.Decrypt(text);
        }
        
        public System.Threading.Tasks.Task<string> DecryptAsync(string text) {
            return base.Channel.DecryptAsync(text);
        }
    }
}
