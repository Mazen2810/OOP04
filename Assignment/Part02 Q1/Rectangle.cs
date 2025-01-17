using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02_Q1
{
    internal class Rectangle : IRectangle
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Area { get; set; }

        public Rectangle(decimal Length , decimal Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public void DisplayShapeInfo()
        {
           Area = Length * Width;
            Console.WriteLine($"The Length = {Length} \nThe Width = {Width} \nArea = {Area}");
        }
    }
}
