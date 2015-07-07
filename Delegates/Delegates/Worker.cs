using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //public delegate void WorkPerformedHandler(int hours, WorkType workType);
    //define delegate that take cutom EventArgs insted of only 2 paramters
    //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);


    
   public  class Worker
   {
       //public event WorkPerformedHandler WorkPerformed;

       // we will use built in .net delegate EventHandler instead of Workperformed delegate

       public event EventHandler<WorkPerformedEventArgs> WorkPerformed; 

       public event EventHandler WorkCompleted;
       public void DoWork(int hours, WorkType workType)
       {
           for (int i = 0; i < hours; i++)
           {
               System.Threading.Thread.Sleep(1000);
               OnWorkPerformed(i+1,workType);
           }
           OnWorkCompleted();
       }

       protected virtual void OnWorkPerformed(int hours, WorkType workType)
       {
           //if (WorkPerformed != null)
           //    WorkPerformed(hours, workType);

           var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
           if (del != null)
           {
               WorkPerformed(this, new WorkPerformedEventArgs(hours, workType));
           }
       }
       protected virtual void OnWorkCompleted()
       {
          
           var del = WorkCompleted as EventHandler;
           if (del != null)
           {
               WorkCompleted(this,EventArgs.Empty);
           }
       }
    }
}
