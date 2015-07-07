using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //var del1= new WorkPerformedHandler(WorkPerformed1);
            //var del2= new WorkPerformedHandler(WorkPerformed2);
            //var del3= new WorkPerformedHandler(WorkPerformed3);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GotToMettings);

            /* inovkation list of multicast
            del1 += del2;
            del1 += del3;
             */

            /* shortcut for invokation list multicast
            del1 += del2 + del3;
             */
          
            

            //del1(10, WorkType.Golf);
            //DoWork(del2);
            var worker = new Worker();
            //worker.WorkPerformed += Worker_WorkPerformed;
            //worker.WorkCompleted += Worker_WorkCompleted;

            //same as the above using lambda expression
            worker.WorkPerformed += (s,e)=>Console.WriteLine("Hours"+ e.Hours +"WorkType "+e.WorkType);
            worker.WorkCompleted += (s,e)=>Console.WriteLine("Work completed");
            worker.DoWork(10,WorkType.GeneratingReports);
            Console.Read();
        }

        //private static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work Completed");
        //}

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine(e.Hours+"  "+e.WorkType);
        //}


        //static void WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("work performed1 called"+hours);
        //}    
        //static void WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("work performed2 called"+hours);
        //}

        //private static void WorkPerformed3(int hours, WorkType worktype)
        //{
        //    Console.WriteLine("Worke performed3 " + hours);
        //}
        //static void DoWork(WorkPerformedHandler dl1)
        //{
        //    dl1(5, WorkType.GeneratingReports);
        //}
    }

    public enum WorkType
    {
        GotToMettings,
        Golf,
        GeneratingReports
    }
}
