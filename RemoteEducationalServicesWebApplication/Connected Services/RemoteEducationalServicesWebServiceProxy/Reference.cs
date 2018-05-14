﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap")]
    public interface RemoteEducationalServicesWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name user from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateUser", ReplyAction="*")]
        RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponse CreateUser(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponse> CreateUserAsync(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateDeveloperAccount", ReplyAction="*")]
        bool CreateDeveloperAccount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateDeveloperAccount", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> CreateDeveloperAccountAsync();
        
        // CODEGEN: Generating message contract since element name user from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateCredentials", ReplyAction="*")]
        RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponse ValidateCredentials(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ValidateCredentials", ReplyAction="*")]
        System.Threading.Tasks.Task<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponse> ValidateCredentialsAsync(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateUser", Namespace="http://tempuri.org/", Order=0)]
        public RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequestBody Body;
        
        public CreateUserRequest() {
        }
        
        public CreateUserRequest(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pass;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string firstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string lastName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string dateOfBirth;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int phoneNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string streetName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int houseNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=9)]
        public int unitNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string suburb;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string state;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public int postCode;
        
        public CreateUserRequestBody() {
        }
        
        public CreateUserRequestBody(string user, string pass, string firstName, string lastName, string email, string dateOfBirth, int phoneNumber, string streetName, int houseNumber, int unitNumber, string suburb, string state, int postCode) {
            this.user = user;
            this.pass = pass;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
            this.unitNumber = unitNumber;
            this.suburb = suburb;
            this.state = state;
            this.postCode = postCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponseBody Body;
        
        public CreateUserResponse() {
        }
        
        public CreateUserResponse(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateUserResult;
        
        public CreateUserResponseBody() {
        }
        
        public CreateUserResponseBody(bool CreateUserResult) {
            this.CreateUserResult = CreateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateCredentialsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateCredentials", Namespace="http://tempuri.org/", Order=0)]
        public RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequestBody Body;
        
        public ValidateCredentialsRequest() {
        }
        
        public ValidateCredentialsRequest(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateCredentialsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string user;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pass;
        
        public ValidateCredentialsRequestBody() {
        }
        
        public ValidateCredentialsRequestBody(string user, string pass) {
            this.user = user;
            this.pass = pass;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateCredentialsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateCredentialsResponse", Namespace="http://tempuri.org/", Order=0)]
        public RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponseBody Body;
        
        public ValidateCredentialsResponse() {
        }
        
        public ValidateCredentialsResponse(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ValidateCredentialsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ValidateCredentialsResult;
        
        public ValidateCredentialsResponseBody() {
        }
        
        public ValidateCredentialsResponseBody(bool ValidateCredentialsResult) {
            this.ValidateCredentialsResult = ValidateCredentialsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RemoteEducationalServicesWebServiceSoapChannel : RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RemoteEducationalServicesWebServiceSoapClient : System.ServiceModel.ClientBase<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap>, RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap {
        
        public RemoteEducationalServicesWebServiceSoapClient() {
        }
        
        public RemoteEducationalServicesWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RemoteEducationalServicesWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteEducationalServicesWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RemoteEducationalServicesWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponse RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap.CreateUser(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest request) {
            return base.Channel.CreateUser(request);
        }
        
        public bool CreateUser(string user, string pass, string firstName, string lastName, string email, string dateOfBirth, int phoneNumber, string streetName, int houseNumber, int unitNumber, string suburb, string state, int postCode) {
            RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest inValue = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest();
            inValue.Body = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequestBody();
            inValue.Body.user = user;
            inValue.Body.pass = pass;
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.email = email;
            inValue.Body.dateOfBirth = dateOfBirth;
            inValue.Body.phoneNumber = phoneNumber;
            inValue.Body.streetName = streetName;
            inValue.Body.houseNumber = houseNumber;
            inValue.Body.unitNumber = unitNumber;
            inValue.Body.suburb = suburb;
            inValue.Body.state = state;
            inValue.Body.postCode = postCode;
            RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponse retVal = ((RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap)(this)).CreateUser(inValue);
            return retVal.Body.CreateUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponse> RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap.CreateUserAsync(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest request) {
            return base.Channel.CreateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserResponse> CreateUserAsync(string user, string pass, string firstName, string lastName, string email, string dateOfBirth, int phoneNumber, string streetName, int houseNumber, int unitNumber, string suburb, string state, int postCode) {
            RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest inValue = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequest();
            inValue.Body = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.CreateUserRequestBody();
            inValue.Body.user = user;
            inValue.Body.pass = pass;
            inValue.Body.firstName = firstName;
            inValue.Body.lastName = lastName;
            inValue.Body.email = email;
            inValue.Body.dateOfBirth = dateOfBirth;
            inValue.Body.phoneNumber = phoneNumber;
            inValue.Body.streetName = streetName;
            inValue.Body.houseNumber = houseNumber;
            inValue.Body.unitNumber = unitNumber;
            inValue.Body.suburb = suburb;
            inValue.Body.state = state;
            inValue.Body.postCode = postCode;
            return ((RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap)(this)).CreateUserAsync(inValue);
        }
        
        public bool CreateDeveloperAccount() {
            return base.Channel.CreateDeveloperAccount();
        }
        
        public System.Threading.Tasks.Task<bool> CreateDeveloperAccountAsync() {
            return base.Channel.CreateDeveloperAccountAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponse RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap.ValidateCredentials(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest request) {
            return base.Channel.ValidateCredentials(request);
        }
        
        public bool ValidateCredentials(string user, string pass) {
            RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest inValue = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest();
            inValue.Body = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequestBody();
            inValue.Body.user = user;
            inValue.Body.pass = pass;
            RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponse retVal = ((RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap)(this)).ValidateCredentials(inValue);
            return retVal.Body.ValidateCredentialsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponse> RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap.ValidateCredentialsAsync(RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest request) {
            return base.Channel.ValidateCredentialsAsync(request);
        }
        
        public System.Threading.Tasks.Task<RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsResponse> ValidateCredentialsAsync(string user, string pass) {
            RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest inValue = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequest();
            inValue.Body = new RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.ValidateCredentialsRequestBody();
            inValue.Body.user = user;
            inValue.Body.pass = pass;
            return ((RemoteEducationalServicesWebApplication.RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoap)(this)).ValidateCredentialsAsync(inValue);
        }
    }
}