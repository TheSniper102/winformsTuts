using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class ImplementInterface : object, IInterface, IInterface1
    {
        public int Name { get; set; }
        public int Age { get; set; }

        public string Test1()
        {
            return "test from IInterface";
        }

        public int Test2()
        {
            return 1;
        }
    }
}
