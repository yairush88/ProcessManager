﻿using System.Collections.Generic;
using System.Linq;

namespace ProcessService
{
    public class ProcessService : IProcessService
    {
        private readonly IList<WinProcess> _winProcesses = new List<WinProcess>();

        public ProcessService()
        {
            
        }

        public IList<WinProcess> GetProcesses()
        {
            InitProcesses();
            return _winProcesses;
        }

        private void InitProcesses()
        {
            
            var processes = System.Diagnostics.Process.GetProcesses().ToList();
            foreach (var process in processes)
            {
                _winProcesses.Clear();
                try
                {
                    _winProcesses.Add(new WinProcess
                    {
                        Name = process.ProcessName,
                        ProcessId = process.Id,
                        TotalProcessorTime = process.TotalProcessorTime.TotalMilliseconds
                    });
                }
                catch { }
            }
        }

        public WinProcess GetProcessById(int processId)
        {
            return _winProcesses.FirstOrDefault(p => p.ProcessId == processId);
        }
    }
}
