using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ListasE
{
    public class Emplyoee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }


        public void increaseSalary(double percentage_s){
            Salary += ((percentage_s/100) * Salary);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}