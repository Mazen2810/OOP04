
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

            #region Shallow Copy vs Deep Copy
            //int[] Arr01 = [1, 2, 3];
            //int[] Arr02 = [4, 5, 6];

            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");


            #region Shallow Copy
            // Arr02 = Arr01; Console.WriteLine("After Shallow Copy --> Arr02 = Arr01");
            /// Shallow Copy
            /// This Object [1,2,3] Has 2 References [Arr01,Arr02]
            /// This Object [4,5,6] became Unreachable object 
            #endregion

            #region Deep Copy
            //Arr02 = (int[])Arr01.Clone(); Console.WriteLine("Deep Copy");
            //// Clone Method: Will Generate new Object with new and different Identity
            ////               This Object will have the same State [Data] of the Caller Object 
            #endregion

            //Console.WriteLine($"Arr01.GetHashCode() = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]); // 100

            //Console.WriteLine("----------------------------");

            //foreach(int numbers in Arr01)
            //{
            //    Console.WriteLine(numbers);
            //} foreach(int numbers in Arr02)
            //{
            //    Console.WriteLine(numbers);
            //} 
            #endregion

            #region Why Clone Method Description says it makes a shallow Copy ?

            //string[] Names01 = ["Ahmed","Mohamed"];
            //string[] Names02 = ["Hossam","Mazen"];

            //Console.WriteLine($"Arr01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Names02.GetHashCode()}");

            //Names02 = (string[])Names01.Clone(); Console.WriteLine("Deep Copy");
            //// Clone Method: Will Generate new Object with new and different Identity
            ////               This Object will have the same State [Data] of the Caller Object 

            //Console.WriteLine($"Arr01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Arr02.GetHashCode() = {Names02.GetHashCode()}");


            //Names02[0] = "Khalid";

            //Console.WriteLine(Names01[0]); // Ahmed
            #endregion
        }
    }
}
