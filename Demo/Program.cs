using Demo.Interface_Ex01;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


           // Itype reference;
            // Declare for reference of type "Itype", containing garbage value
            /// this Reference can refer to an Object of any type Implementing IType Interface
            /// CLR will Allocate 4 unintialized Bytes in Stack for this reference
            /// CLR will allocate 0 Bytes in HEAP


            // reference = new Itype(); INVALID

            //reference = new TypeA();
            //reference.MyProperty = 10;
            //reference.MyMethod();
            //reference.Print();


            //TypeA typeA = new TypeA();
            //typeA.MyProperty = 20;
            //typeA.MyMethod();
            //typeA.Print():   // INVALID , can't see this method

        }
    }
}
