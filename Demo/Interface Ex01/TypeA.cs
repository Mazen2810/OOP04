using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
  // Developer ---> 2
{
    internal class TypeA : Itype
    {
        public int MyProperty { get; set; }

        public void MyMethod()
        {
            Console.WriteLine("Hello World!"); ;
        }
    }
}
