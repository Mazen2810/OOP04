using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class Airplane : Vehicle, IMoveable, IFlyable
    {
        public void Backward()
        {
            throw new NotImplementedException();
        }

         void IMoveable.Forward()
        {
            Console.WriteLine("Airplane move forward on Ground"); ;
        }
         void IFlyable.Forward()
        {
            Console.WriteLine("Airplane move forward on Air"); ;
            ;
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
