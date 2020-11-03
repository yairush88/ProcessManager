using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ProcessService
{
    [ServiceContract]
    public interface IProcessService
    {
        [OperationContract]
        IList<WinProcess> GetProcesses();

        [OperationContract]
        WinProcess GetProcessById(int processId);
    }

    [DataContract]
    public class WinProcess
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int ProcessId { get; set; }
        [DataMember]
        public double TotalProcessorTime { get; set; }
    }
}
