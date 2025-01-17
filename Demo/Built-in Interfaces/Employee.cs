using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_in_Interfaces
{
     class Employee : ICloneable
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Department? Department { get; set; }
        public object Clone()
        {
            return new Employee()
            {
                id = this.id,
                Name = this.Name,
                // Name = (string?) this.Name.Clone(),
                Salary = this.Salary,
                Department = (Department?) this.Department?.Clone()
            };
        }

        public override string ToString()
        {
            return $"Id: {id}, Name: {Name}, Salary: {Salary:C}";
        }
    }
}
