namespace ServiceClient.CryptoServiceReference2
{
    // Функция 2
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CheckMass", Namespace = "http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CheckMass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceStringField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceStringField1;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SourceString
        {
            get
            {
                return this.SourceStringField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SourceStringField, value) != true))
                {
                    this.SourceStringField = value;
                    this.RaisePropertyChanged("SourceString");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string SourceString1
        {
            get
            {
                return this.SourceStringField1;
            }
            set
            {
                if ((object.ReferenceEquals(this.SourceStringField1, value) != true))
                {
                    this.SourceStringField1 = value;
                    this.RaisePropertyChanged("SourceString1");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CryptoServiceReference2.CryptoServiceSoap")]
    public interface CryptoServiceSoap
    {
        // CODEGEN: Generating message contract since element name str from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MassCheck", ReplyAction = "*")]
        ServiceClient.CryptoServiceReference2.MassCheckResponse MassCheck(ServiceClient.CryptoServiceReference2.MassCheckRequest request);
    }
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class MassCheckRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "MassCheck", Namespace = "http://tempuri.org/", Order = 0)]
        public ServiceClient.CryptoServiceReference2.MassCheckRequestBody Body;

        public MassCheckRequest()
        {
        }

        public MassCheckRequest(ServiceClient.CryptoServiceReference2.MassCheckRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class MassCheckRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference2.CheckMass str;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference2.CheckMass key;

        public MassCheckRequestBody()
        {
        }

        public MassCheckRequestBody(ServiceClient.CryptoServiceReference2.CheckMass str)
        {
            this.str = str;
            //this.key = key;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class MassCheckResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "MassCheckResult", Namespace = "http://tempuri.org/", Order = 0)]
        public ServiceClient.CryptoServiceReference2.MassCheckResponseBody Body;

        public MassCheckResponse()
        {
        }

        public MassCheckResponse(ServiceClient.CryptoServiceReference2.MassCheckResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class MassCheckResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference2.MassCheck MassCheckResult;

        public MassCheckResponseBody()
        {
        }

        public MassCheckResponseBody(ServiceClient.CryptoServiceReference2.CheckMass MassCheckResult)
        {
            this.MassCheckResult = MassCheckResult;
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CryptoServiceSoapChannel : ServiceClient.CryptoServiceReference2.CryptoServiceSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CryptoServiceSoapClient : System.ServiceModel.ClientBase<ServiceClient.CryptoServiceReference2.CryptoServiceSoap>, ServiceClient.CryptoServiceReference2.CryptoServiceSoap
    {

        public CryptoServiceSoapClient()
        {
        }

        public CryptoServiceSoapClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public CryptoServiceSoapClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CryptoServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CryptoServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceClient.CryptoServiceReference2.MassCheckResponse ServiceClient.CryptoServiceReference2.CryptoServiceSoap.MassCheck(ServiceClient.CryptoServiceReference2.MassCheckRequest request)
        {
            return base.Channel.MassCheck(request);
        }

        public ServiceClient.CryptoServiceReference2.CheckMass MassCheck(ServiceClient.CryptoServiceReference2.CheckMass str)
        {
            ServiceClient.CryptoServiceReference2.MassCheckRequest inValue = new ServiceClient.CryptoServiceReference2.MassCheckRequest();
            inValue.Body = new ServiceClient.CryptoServiceReference2.MassCheckRequestBody();
            inValue.Body.str = str;
            ServiceClient.CryptoServiceReference2.MassCheckResponse retVal = ((ServiceClient.CryptoServiceReference2.CryptoServiceSoap)(this)).MassCheck(inValue);
            return retVal.Body.MassCheckResult;
        }
    }
}