using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex01
{  // Developer ---> 1
    internal interface Itype
    {
        // Public Access Modifier is the Default Access Modifier inside the Interface.
        // Private Access Modifier is not Allowed for Signatures only [Property, Methods]


        // what you can write inside the interface ?

        // 1. Signature for property
        public int MyProperty { get; set; }

        // 2. Signature for method
        public void MyMethod();

        // 3. Default Implemented Method [C# 8.0 New feature (>NET Core 3.1 [2019])]
        public void Print()
        {
            Console.WriteLine("Default Implemented Method");
        }

        /// // 4. Static Members [C# 8.0 New feature (>NET Core 3.1 [2019])]
        ///
        ///    // 4.1 Static Fields
        ///    // 4.2 Static Properties
        ///    // 4.3 Static Methods
        ///    // 4.4 Static Events
    }
}
