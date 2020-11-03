using System;
using System.ServiceModel;

namespace ProcessManagerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ProcessService.ProcessService)))
            {
                host.Open();
                Console.WriteLine($"Host started at {DateTime.Now}");
                Console.ReadLine();
            }
        }
    }
}
