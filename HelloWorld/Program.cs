using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    internal class Program // Inicio do Programa
	{
        
        static void Main(string[] args) // Função principal
        {

            int segundaGuerraMundial = 1945;
            float velocidade = 294.56f;

            // variáveis
            int numero = 2;
            var letra = 'c';
            dynamic qualquerCoisa = true;

            // constantes
            const float PI = 3.14f;

            // I/O
            string name = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(name);

            // Operações aritméticas

            int num = 10;
            int resultado = num + numero;
            int resultado2 = num - numero;
            int resultado3 = num * numero;

            var resultado4 = num / numero;

            Console.WriteLine((resultado, resultado2, resultado3, resultado4));

        }

    } // Fim do Programa
}
