using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Models
{
    public class Person
    {

        public Person(){}
        public Person(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        private string _nome;
        // Fazer o mesmo para idade
        
        public string Nome
        {
            get => _nome.ToUpper();

            set {
                if (value == ""){
                    throw new ArgumentException("O nome nao pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"{Nome} - {Idade}");
        }

    }
}