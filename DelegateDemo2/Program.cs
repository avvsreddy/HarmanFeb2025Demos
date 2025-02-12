using System.Diagnostics;

namespace DelegateDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Developer 1 -  all processes
            ProcessManager pMgr = new ProcessManager();

            //pMgr.ShowProcessList(NoFilter);

            // Anonymous Delegates
            //pMgr.ShowProcessList(delegate
            //{
            //    return true;
            //});

            // Anonymous Delegates => Lambda Expression
            pMgr.ShowProcessList(p => true);

            // Client 2 - starts with S
            //pMgr.ShowProcessList("S");
            //FilterDelegate filter = new FilterDelegate(FilterByName);
            //pMgr.ShowProcessList(filter);
            //pMgr.ShowProcessList(delegate (Process p)
            //{
            //    if (p.ProcessName.StartsWith("S"))
            //        return true;
            //    return false;
            //});


            // Client 3
            //pMgr.ShowProcessList(FilterBySize);
            // Anonymouse Delegate

            pMgr.ShowProcessList(delegate (Process p)
            {
                return p.WorkingSet64 >= 100 * 1024 * 1024;
            });

            // Lambda Expression => Light Weight Syntax for Anonymous Delegates


            // Anonymouse Delegate => Lambda Statement

            pMgr.ShowProcessList((Process p) =>
            {
                return p.WorkingSet64 >= 100 * 1024 * 1024;
            });

            // Anonymouse Delegate => Lambda Statement => Lambda Expression

            pMgr.ShowProcessList((Process p) =>

                 p.WorkingSet64 >= 100 * 1024 * 1024
            );

            pMgr.ShowProcessList(p => p.WorkingSet64 >= 100 * 1024 * 1024);
        }

        // Client 1

        //public static bool NoFilter(Process p)
        //{
        //    return true;
        //}


        // client 2
        //public static bool FilterByName(Process p)
        //{
        //    if (p.ProcessName.StartsWith("S"))
        //        return true;
        //    return false;
        //}

        // client 3
        //public static bool FilterBySize(Process p)
        //{
        //    return p.WorkingSet64 >= 100 * 1024 * 1024;
        //}
    }


    // Dev 1
    // declare

    public delegate bool FilterDelegate(Process p);

    class ProcessManager // OCP
    {
        //public void ShowProcessList()
        //{
        //    foreach (var p in Process.GetProcesses())
        //    {
        //        Console.WriteLine(p.ProcessName);
        //    }
        //}
        public void ShowProcessList(FilterDelegate filter)
        {
            foreach (var p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }

        //public void ShowProcessList(long size)
        //{
        //    foreach (var p in Process.GetProcesses())
        //    {
        //        if (p.WorkingSet64 >= size)
        //            Console.WriteLine(p.ProcessName);
        //    }
        //}
    }
}
