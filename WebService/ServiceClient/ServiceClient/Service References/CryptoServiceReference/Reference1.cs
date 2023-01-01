namespace ServiceClient.CryptoServiceReference1
{
    // Функция 2
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Str256", Namespace = "http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Str256 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CryptoServiceReference1.CryptoServiceSoap")]
    public interface CryptoServiceSoap
    {
        // CODEGEN: Generating message contract since element name str from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/SumMass", ReplyAction = "*")]
        ServiceClient.CryptoServiceReference1.SumMassResponse SumMass(ServiceClient.CryptoServiceReference1.SumMassRequest request);
    }
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class SumMassRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "SumMass", Namespace = "http://tempuri.org/", Order = 0)]
        public ServiceClient.CryptoServiceReference1.SumMassRequestBody Body;

        public SumMassRequest()
        {
        }

        public SumMassRequest(ServiceClient.CryptoServiceReference1.SumMassRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class SumMassRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference1.Str256 str;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference1.Str256 key;

        public SumMassRequestBody()
        {
        }

        public SumMassRequestBody(ServiceClient.CryptoServiceReference1.Str256 str)
        {
            this.str = str;
            //this.key = key;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class SumMassResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "SumMassResult", Namespace = "http://tempuri.org/", Order = 0)]
        public ServiceClient.CryptoServiceReference1.SumMassResponseBody Body;

        public SumMassResponse()
        {
        }

        public SumMassResponse(ServiceClient.CryptoServiceReference1.SumMassResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class SumMassResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference1.Str256 SumMassResult;

        public SumMassResponseBody()
        {
        }

        public SumMassResponseBody(ServiceClient.CryptoServiceReference1.Str256 SumMassResult)
        {
            this.SumMassResult = SumMassResult;
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CryptoServiceSoapChannel : ServiceClient.CryptoServiceReference1.CryptoServiceSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CryptoServiceSoapClient : System.ServiceModel.ClientBase<ServiceClient.CryptoServiceReference1.CryptoServiceSoap>, ServiceClient.CryptoServiceReference1.CryptoServiceSoap
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
        ServiceClient.CryptoServiceReference1.SumMassResponse ServiceClient.CryptoServiceReference1.CryptoServiceSoap.SumMass(ServiceClient.CryptoServiceReference1.SumMassRequest request)
        {
            return base.Channel.SumMass(request);
        }

        public ServiceClient.CryptoServiceReference1.Str256 SumMass(ServiceClient.CryptoServiceReference1.Str256 str)
        {
            ServiceClient.CryptoServiceReference1.SumMassRequest inValue = new ServiceClient.CryptoServiceReference1.SumMassRequest();
            inValue.Body = new ServiceClient.CryptoServiceReference1.SumMassRequestBody();
            inValue.Body.str = str;
            ServiceClient.CryptoServiceReference1.SumMassResponse retVal = ((ServiceClient.CryptoServiceReference1.CryptoServiceSoap)(this)).SumMass(inValue);
            return retVal.Body.SumMassResult;
        }
    }
}