﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.webservice {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="webservice.ageVerifySoap")]
    public interface ageVerifySoap {
        
        // CODEGEN: Generating message contract since element name validateAgeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validateAge", ReplyAction="*")]
        WebApplication1.webservice.validateAgeResponse validateAge(WebApplication1.webservice.validateAgeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/validateAge", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.webservice.validateAgeResponse> validateAgeAsync(WebApplication1.webservice.validateAgeRequest request);
        
        // CODEGEN: Generating message contract since element name code from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createHashCode", ReplyAction="*")]
        WebApplication1.webservice.createHashCodeResponse createHashCode(WebApplication1.webservice.createHashCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createHashCode", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication1.webservice.createHashCodeResponse> createHashCodeAsync(WebApplication1.webservice.createHashCodeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateAgeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validateAge", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.webservice.validateAgeRequestBody Body;
        
        public validateAgeRequest() {
        }
        
        public validateAgeRequest(WebApplication1.webservice.validateAgeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validateAgeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int age;
        
        public validateAgeRequestBody() {
        }
        
        public validateAgeRequestBody(int age) {
            this.age = age;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validateAgeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validateAgeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.webservice.validateAgeResponseBody Body;
        
        public validateAgeResponse() {
        }
        
        public validateAgeResponse(WebApplication1.webservice.validateAgeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class validateAgeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string validateAgeResult;
        
        public validateAgeResponseBody() {
        }
        
        public validateAgeResponseBody(string validateAgeResult) {
            this.validateAgeResult = validateAgeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createHashCodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createHashCode", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.webservice.createHashCodeRequestBody Body;
        
        public createHashCodeRequest() {
        }
        
        public createHashCodeRequest(WebApplication1.webservice.createHashCodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class createHashCodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string code;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string salt;
        
        public createHashCodeRequestBody() {
        }
        
        public createHashCodeRequestBody(string code, string salt) {
            this.code = code;
            this.salt = salt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createHashCodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="createHashCodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication1.webservice.createHashCodeResponseBody Body;
        
        public createHashCodeResponse() {
        }
        
        public createHashCodeResponse(WebApplication1.webservice.createHashCodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class createHashCodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string createHashCodeResult;
        
        public createHashCodeResponseBody() {
        }
        
        public createHashCodeResponseBody(string createHashCodeResult) {
            this.createHashCodeResult = createHashCodeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ageVerifySoapChannel : WebApplication1.webservice.ageVerifySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ageVerifySoapClient : System.ServiceModel.ClientBase<WebApplication1.webservice.ageVerifySoap>, WebApplication1.webservice.ageVerifySoap {
        
        public ageVerifySoapClient() {
        }
        
        public ageVerifySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ageVerifySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ageVerifySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ageVerifySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.webservice.validateAgeResponse WebApplication1.webservice.ageVerifySoap.validateAge(WebApplication1.webservice.validateAgeRequest request) {
            return base.Channel.validateAge(request);
        }
        
        public string validateAge(int age) {
            WebApplication1.webservice.validateAgeRequest inValue = new WebApplication1.webservice.validateAgeRequest();
            inValue.Body = new WebApplication1.webservice.validateAgeRequestBody();
            inValue.Body.age = age;
            WebApplication1.webservice.validateAgeResponse retVal = ((WebApplication1.webservice.ageVerifySoap)(this)).validateAge(inValue);
            return retVal.Body.validateAgeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.webservice.validateAgeResponse> WebApplication1.webservice.ageVerifySoap.validateAgeAsync(WebApplication1.webservice.validateAgeRequest request) {
            return base.Channel.validateAgeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.webservice.validateAgeResponse> validateAgeAsync(int age) {
            WebApplication1.webservice.validateAgeRequest inValue = new WebApplication1.webservice.validateAgeRequest();
            inValue.Body = new WebApplication1.webservice.validateAgeRequestBody();
            inValue.Body.age = age;
            return ((WebApplication1.webservice.ageVerifySoap)(this)).validateAgeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.webservice.createHashCodeResponse WebApplication1.webservice.ageVerifySoap.createHashCode(WebApplication1.webservice.createHashCodeRequest request) {
            return base.Channel.createHashCode(request);
        }
        
        public string createHashCode(string code, string salt) {
            WebApplication1.webservice.createHashCodeRequest inValue = new WebApplication1.webservice.createHashCodeRequest();
            inValue.Body = new WebApplication1.webservice.createHashCodeRequestBody();
            inValue.Body.code = code;
            inValue.Body.salt = salt;
            WebApplication1.webservice.createHashCodeResponse retVal = ((WebApplication1.webservice.ageVerifySoap)(this)).createHashCode(inValue);
            return retVal.Body.createHashCodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication1.webservice.createHashCodeResponse> WebApplication1.webservice.ageVerifySoap.createHashCodeAsync(WebApplication1.webservice.createHashCodeRequest request) {
            return base.Channel.createHashCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.webservice.createHashCodeResponse> createHashCodeAsync(string code, string salt) {
            WebApplication1.webservice.createHashCodeRequest inValue = new WebApplication1.webservice.createHashCodeRequest();
            inValue.Body = new WebApplication1.webservice.createHashCodeRequestBody();
            inValue.Body.code = code;
            inValue.Body.salt = salt;
            return ((WebApplication1.webservice.ageVerifySoap)(this)).createHashCodeAsync(inValue);
        }
    }
}