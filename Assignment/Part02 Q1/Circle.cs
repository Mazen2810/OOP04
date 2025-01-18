using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02_Q1
{
    internal class Circle : ICircle
    {
        public decimal Radius { get; set; }
        public decimal Area { get; set; }

        public Circle(decimal Radius)
        {
            this.Radius = Radius;
        }

       

        public void DisplayShapeInfo()
        {
            Area = 3.14M * Radius * Radius;
            Console.WriteLine($"Radius = {Radius} \nArea = {Area}");
        }
    }
}
