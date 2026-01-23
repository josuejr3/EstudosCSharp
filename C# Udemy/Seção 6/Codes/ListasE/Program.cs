using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListasE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Emplyoee> emplyoeeList = new List<Emplyoee>();
            
            Console.Write("How many emplyoee will be registred? ");
            int amountEmplyoee = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= amountEmplyoee; i++){
                
                Console.WriteLine($"Emplyoee #{i}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                emplyoeeList.Add(new Emplyoee(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the emplyoee id that will have salary increase : ");
            int numberEmplyoee = int.Parse(Console.ReadLine()!);
            
            Emplyoee e_number = emplyoeeList.Find(x => x.Id == numberEmplyoee);

            if (e_number == null)
            {
                Console.WriteLine("The ID does not exist");
            } else{
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                e_number.increaseSalary(percentage);
            }


            Console.WriteLine();
            Console.WriteLine("Updated list of employees");

            foreach (Emplyoee e in emplyoeeList)
            {
                Console.WriteLine(e);
            }

        }
    }
}