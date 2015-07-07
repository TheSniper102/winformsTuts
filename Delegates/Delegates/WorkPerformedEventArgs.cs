using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     Give us flexability to define more that two paramters for delegate
     */
   public class WorkPerformedEventArgs:EventArgs
    {
       public WorkPerformedEventArgs(int hours, WorkType workType)
       {
           Hours = hours;
           WorkType = workType;
       }
       public int Hours { get; set; }
       public WorkType WorkType { get; set; }
    }
}
