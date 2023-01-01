namespace ServiceClient.CryptoServiceReference3
{
    // Функция 2
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CheckStr", Namespace = "http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CheckStr : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CryptoServiceReference3.CryptoServiceSoap")]
    public interface CryptoServiceSoap
    {
        // CODEGEN: Generating message contract since element name str from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/StrCheck", ReplyAction = "*")]
        ServiceClient.CryptoServiceReference3.StrCheckResponse StrCheck(ServiceClient.CryptoServiceReference3.StrCheckRequest request);
    }
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class StrCheckRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "StrCheck", Namespace = "http://tempuri.org/", Order = 0)]
        public ServiceClient.CryptoServiceReference3.StrCheckRequestBody Body;

        public StrCheckRequest()
        {
        }

        public StrCheckRequest(ServiceClient.CryptoServiceReference3.StrCheckRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class StrCheckRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference3.CheckStr str;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference3.CheckStr key;

        public StrCheckRequestBody()
        {
        }

        public StrCheckRequestBody(ServiceClient.CryptoServiceReference3.CheckStr str)
        {
            this.str = str;
            //this.key = key;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class StrCheckResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "StrCheckResult", Namespace = "http://tempuri.org/", Order = 0)]
        public ServiceClient.CryptoServiceReference3.StrCheckResponseBody Body;

        public StrCheckResponse()
        {
        }

        public StrCheckResponse(ServiceClient.CryptoServiceReference3.StrCheckResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class StrCheckResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ServiceClient.CryptoServiceReference3.StrCheck StrCheckResult;

        public StrCheckResponseBody()
        {
        }

        public StrCheckResponseBody(ServiceClient.CryptoServiceReference3.CheckStr StrCheckResult)
        {
            this.StrCheckResult = StrCheckResult;
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CryptoServiceSoapChannel : ServiceClient.CryptoServiceReference3.CryptoServiceSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CryptoServiceSoapClient : System.ServiceModel.ClientBase<ServiceClient.CryptoServiceReference3.CryptoServiceSoap>, ServiceClient.CryptoServiceReference3.CryptoServiceSoap
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
        ServiceClient.CryptoServiceReference3.StrCheckResponse ServiceClient.CryptoServiceReference3.CryptoServiceSoap.StrCheck(ServiceClient.CryptoServiceReference3.StrCheckRequest request)
        {
            return base.Channel.StrCheck(request);
        }

        public ServiceClient.CryptoServiceReference3.CheckStr StrCheck(ServiceClient.CryptoServiceReference3.CheckStr str)
        {
            ServiceClient.CryptoServiceReference3.StrCheckRequest inValue = new ServiceClient.CryptoServiceReference3.StrCheckRequest();
            inValue.Body = new ServiceClient.CryptoServiceReference3.StrCheckRequestBody();
            inValue.Body.str = str;
            ServiceClient.CryptoServiceReference3.StrCheckResponse retVal = ((ServiceClient.CryptoServiceReference3.CryptoServiceSoap)(this)).StrCheck(inValue);
            return retVal.Body.StrCheckResult;
        }
    }
}