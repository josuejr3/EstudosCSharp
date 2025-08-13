using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EstudosCSharp.Models
{
    public class Calculadora
    {
        public void Somar(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        
        // Usando a classe math (como se fosse um pacote)

        public void Potencia(int num1, int num2)
        {
            double resp = Math.Pow(num1, num2);
            Console.WriteLine($"{num1}^{num2} = {resp}");
        }

        public void Seno(int angulo)
        {
            double radiano = angulo * Math.PI;
            double resp = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(resp, 2)}");
        }
        
    }
    
}

