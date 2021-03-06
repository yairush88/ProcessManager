﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcessService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WinProcess", Namespace="http://schemas.datacontract.org/2004/07/ProcessService")]
    public partial class WinProcess : object
    {
        
        private string NameField;
        
        private int ProcessIdField;
        
        private double TotalProcessorTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProcessId
        {
            get
            {
                return this.ProcessIdField;
            }
            set
            {
                this.ProcessIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TotalProcessorTime
        {
            get
            {
                return this.TotalProcessorTimeField;
            }
            set
            {
                this.TotalProcessorTimeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProcessService.IProcessService")]
    public interface IProcessService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessService/GetProcesses", ReplyAction="http://tempuri.org/IProcessService/GetProcessesResponse")]
        ProcessService.WinProcess[] GetProcesses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessService/GetProcesses", ReplyAction="http://tempuri.org/IProcessService/GetProcessesResponse")]
        System.Threading.Tasks.Task<ProcessService.WinProcess[]> GetProcessesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessService/GetProcessById", ReplyAction="http://tempuri.org/IProcessService/GetProcessByIdResponse")]
        ProcessService.WinProcess GetProcessById(int processId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessService/GetProcessById", ReplyAction="http://tempuri.org/IProcessService/GetProcessByIdResponse")]
        System.Threading.Tasks.Task<ProcessService.WinProcess> GetProcessByIdAsync(int processId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IProcessServiceChannel : ProcessService.IProcessService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ProcessServiceClient : System.ServiceModel.ClientBase<ProcessService.IProcessService>, ProcessService.IProcessService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ProcessServiceClient() : 
                base(ProcessServiceClient.GetDefaultBinding(), ProcessServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.basicHttpBinding_IProcessService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ProcessServiceClient.GetBindingForEndpoint(endpointConfiguration), ProcessServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ProcessServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ProcessServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ProcessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ProcessService.WinProcess[] GetProcesses()
        {
            return base.Channel.GetProcesses();
        }
        
        public System.Threading.Tasks.Task<ProcessService.WinProcess[]> GetProcessesAsync()
        {
            return base.Channel.GetProcessesAsync();
        }
        
        public ProcessService.WinProcess GetProcessById(int processId)
        {
            return base.Channel.GetProcessById(processId);
        }
        
        public System.Threading.Tasks.Task<ProcessService.WinProcess> GetProcessByIdAsync(int processId)
        {
            return base.Channel.GetProcessByIdAsync(processId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.basicHttpBinding_IProcessService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.basicHttpBinding_IProcessService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/ProcessService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ProcessServiceClient.GetBindingForEndpoint(EndpointConfiguration.basicHttpBinding_IProcessService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ProcessServiceClient.GetEndpointAddress(EndpointConfiguration.basicHttpBinding_IProcessService);
        }
        
        public enum EndpointConfiguration
        {
            
            basicHttpBinding_IProcessService,
        }
    }
}
