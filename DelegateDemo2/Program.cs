using System.Diagnostics;

namespace DelegateDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Developer 1 -  all processes
            ProcessManager pMgr = new ProcessManager();
            //pMgr.ShowProcessList();
            // Client 2 - starts with S
            //pMgr.ShowProcessList("S");

            // Client 3
            pMgr.ShowProcessList(100 * 1024 * 1024);
        }
    }

    // Dev 1
    class ProcessManager
    {
        public void ShowProcessList()
        {
            foreach (var p in Process.GetProcesses())
            {
                Console.WriteLine(p.ProcessName);
            }
        }
        public void ShowProcessList(string sw)
        {
            foreach (var p in Process.GetProcesses())
            {
                if (p.ProcessName.StartsWith(sw))
                    Console.WriteLine(p.ProcessName);
            }
        }

        public void ShowProcessList(long size)
        {
            foreach (var p in Process.GetProcesses())
            {
                if (p.WorkingSet64 >= size)
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}
