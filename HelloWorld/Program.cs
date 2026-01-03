using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    internal class Program // Inicio do Programa
	{


		enum Cor { Azul = 23, Verde = 1, Amarelo = 13, Vermelho = 8 };



		static void Main(string[] args) // Função principal
        {

            // Arrays
            string[] products = new string[5] {
                "Lol",
                "Lost Ark",
                "NFS Unbound",
                "PdE",
                "Marvel Rivals"
            };

			int[] values = { 1, 2, 3, 4, 5 };

			Console.WriteLine(products);  
            Console.WriteLine(products[2]);

            Cor corFavorita = Cor.Azul;
			Console.WriteLine(corFavorita);


			int contador = 0;
			while (contador < 10)
			{
				contador++;
			}
			Console.WriteLine("Terminou!");


			int[] numeros = { 1, 2, 3, 4, 5 };
			foreach (int numero in numeros){
				Console.WriteLine(numero);
			}

		}


	} // Fim do Programa
}
