using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public abstract class AbstractClass
    {
        public int  Age { get; set; }
        public string Name { get; set; }

        public string  test1()
        {
            return "test from abstarct  class";
        }
        public abstract void GetName();
    }
}
