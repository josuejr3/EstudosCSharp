using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosCSharp.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegal { get; set; }
        
        public void Apresentar() // @class)
        {
            // Variáveis podem ter nomes dedicados com @
            // @class = "teste";
            Console.WriteLine($"Apresentar {Nome}, {Idade}\nxD\n{NomeRepresentanteLegal}");
        }
    }
}

