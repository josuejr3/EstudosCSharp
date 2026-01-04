using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming {
    public class Player {
        
        public int Age;
        public bool IsActive;
        public string Name;

        public Player(string name) {
            Age = 23;
            IsActive = true;
            Name = name;
        }

        ~Player() {
            Console.WriteLine("Destroyed");
        }

    
        
    } 
    
    class Program {
        static void Main(string[] args){
            
            Player faker = new  Player("Faker");
            
            // Vendo a propriedade
            Console.WriteLine(faker.Age);
            // Editando a propriedade
            faker.Age = 27;
            Console.WriteLine($"Idade do Fake: {faker.Age} e ele está vivo: {faker.IsActive}");
            Console.WriteLine(faker.Name);

            string newNamePlayer = Console.ReadLine();
            faker.Name = newNamePlayer;
            
            Console.WriteLine(faker.Name);
        }
    }
}
