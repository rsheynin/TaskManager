using System;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;

namespace WindowsTaskManagerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            var runningAppCount = 0;
            foreach (var process in processes)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    
                    Console.WriteLine(process.ProcessName);
                    Console.WriteLine(process.MainWindowTitle);
                    Console.WriteLine("######################");
                    runningAppCount++;
                }
            }
            Console.WriteLine("runningAppCount : {0}", runningAppCount);



            foreach (var theprocess in processes)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            Console.WriteLine("processesCount : {0}", processes.Count());


            // get list of Windows services
            var services = ServiceController.GetServices();

            // try to find service name
            foreach (var service in services)
            {
                Console.WriteLine(service.ServiceName);
            }
            Console.WriteLine("servicesCount : {0}", services.Count());


            Console.ReadKey();
        }
    }
}
