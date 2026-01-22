using System;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Room[] quartos = new Room[10];

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= rooms; i++){
                
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numberRoom = int.Parse(Console.ReadLine());

                quartos[numberRoom] = new Room(name, email);

            }

            Console.WriteLine();            
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null){
                    Console.WriteLine($"{i}: {quartos[i]}");
                }
            }


        }
    }
}