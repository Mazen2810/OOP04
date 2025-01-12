
using Demo.Interface_Ex02;
using Demo.Interface_Ex03;

namespace Demo
{
    internal class Program
    {
        #region Interface Ex02
        static void PrintTenNUmbersFromSeries(ISeries series)
        {
            if (series == null)
            {
                return;
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{series.Current} \t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        } 
        #endregion
        static void Main(string[] args)
        {


            #region Interface Ex01
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
            #endregion

            #region Interface Ex02
            //TypeA seriesByTwo = new TypeA();
            //PrintTenNUmbersFromSeries(seriesByTwo);

            //TypeB seriesByThree = new TypeB();
            //PrintTenNUmbersFromSeries(seriesByThree);

            //TypeC seriesByFour = new TypeC();
            //PrintTenNUmbersFromSeries(seriesByThree); 
            #endregion

            #region Interface Ex03


            //Airplane airplane = new Airplane();
            //airplane.Speed = 480;
            ////airplane.forward();


            //IMoveable moveable = airplane;
            //moveable.Forward();

            //IFlyable flyable = airplane;
            //flyable.Forward();

            #endregion
        }
    }
}
