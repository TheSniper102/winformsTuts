using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public interface IInterface
    {
       int Name { get; set; }
       int Age { get; set; }
       string Test1();
       int  Test2();
    }
}
