using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParellalAction pa = new ParellalAction();
            PrimaryTasks pt = new PrimaryTasks();

            Thread T1 = new Thread(pa.Ptask1);
            Thread T2 = new Thread(pt.DisplayDealerData);
            T2.Priority = ThreadPriority.Highest;
            T1.Priority = ThreadPriority.Normal;
            T1.Start();                        
            T2.Start();

            T1 = new Thread(pa.Ptask2);
            T1.Start();
            T1.Priority = ThreadPriority.Normal;
            T1 = new Thread(pa.Ptask3);
            T1.Start();
            T1.Priority = ThreadPriority.Normal;



            Console.Read();
        }
    }
}
