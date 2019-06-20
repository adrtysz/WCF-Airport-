﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Connection", Namespace="http://schemas.datacontract.org/2004/07/Airport")]
    [System.SerializableAttribute()]
    public partial class Connection : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan ArrivalTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan StartTimeField;
        
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
        public System.TimeSpan ArrivalTime {
            get {
                return this.ArrivalTimeField;
            }
            set {
                if ((this.ArrivalTimeField.Equals(value) != true)) {
                    this.ArrivalTimeField = value;
                    this.RaisePropertyChanged("ArrivalTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DestinationCity {
            get {
                return this.DestinationCityField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationCityField, value) != true)) {
                    this.DestinationCityField = value;
                    this.RaisePropertyChanged("DestinationCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FromCity {
            get {
                return this.FromCityField;
            }
            set {
                if ((object.ReferenceEquals(this.FromCityField, value) != true)) {
                    this.FromCityField = value;
                    this.RaisePropertyChanged("FromCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectionNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/Airport")]
    [System.SerializableAttribute()]
    public partial class ConnectionNotFoundFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _messageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _message {
            get {
                return this._messageField;
            }
            set {
                if ((object.ReferenceEquals(this._messageField, value) != true)) {
                    this._messageField = value;
                    this.RaisePropertyChanged("_message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.IAirport")]
    public interface IAirport {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IAirport/GetConnection", ReplyAction="http://Microsoft.ServiceModel.Samples/IAirport/GetConnectionResponse")]
        Client.ServiceReference1.Connection GetConnection(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IAirport/GetConnection", ReplyAction="http://Microsoft.ServiceModel.Samples/IAirport/GetConnectionResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Connection> GetConnectionAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IAirport/GetAllConnections", ReplyAction="http://Microsoft.ServiceModel.Samples/IAirport/GetAllConnectionsResponse")]
        Client.ServiceReference1.Connection[] GetAllConnections();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IAirport/GetAllConnections", ReplyAction="http://Microsoft.ServiceModel.Samples/IAirport/GetAllConnectionsResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Connection[]> GetAllConnectionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IAirport/GetConnections", ReplyAction="http://Microsoft.ServiceModel.Samples/IAirport/GetConnectionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.ServiceReference1.ConnectionNotFoundFault), Action="http://Microsoft.ServiceModel.Samples/IAirport/GetConnectionsConnectionNotFoundFa" +
            "ultFault", Name="ConnectionNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/Airport")]
        Client.ServiceReference1.Connection[] GetConnections(string fromCity, string destinationCity, System.TimeSpan departureTime, System.TimeSpan arrivalTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IAirport/GetConnections", ReplyAction="http://Microsoft.ServiceModel.Samples/IAirport/GetConnectionsResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Connection[]> GetConnectionsAsync(string fromCity, string destinationCity, System.TimeSpan departureTime, System.TimeSpan arrivalTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAirportChannel : Client.ServiceReference1.IAirport, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AirportClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IAirport>, Client.ServiceReference1.IAirport {
        
        public AirportClient() {
        }
        
        public AirportClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AirportClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirportClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirportClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ServiceReference1.Connection GetConnection(int number) {
            return base.Channel.GetConnection(number);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Connection> GetConnectionAsync(int number) {
            return base.Channel.GetConnectionAsync(number);
        }
        
        public Client.ServiceReference1.Connection[] GetAllConnections() {
            return base.Channel.GetAllConnections();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Connection[]> GetAllConnectionsAsync() {
            return base.Channel.GetAllConnectionsAsync();
        }
        
        public Client.ServiceReference1.Connection[] GetConnections(string fromCity, string destinationCity, System.TimeSpan departureTime, System.TimeSpan arrivalTime) {
            return base.Channel.GetConnections(fromCity, destinationCity, departureTime, arrivalTime);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Connection[]> GetConnectionsAsync(string fromCity, string destinationCity, System.TimeSpan departureTime, System.TimeSpan arrivalTime) {
            return base.Channel.GetConnectionsAsync(fromCity, destinationCity, departureTime, arrivalTime);
        }
    }
}