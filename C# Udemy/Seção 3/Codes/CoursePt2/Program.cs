using System;

namespace CoursePt2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Operadores Comparativos

			int a = 10;
			bool c1 = a < 10;
			bool c2 = a < 20;
			bool c3 = a > 10;
			bool c4 = a > 5;

            Console.WriteLine(c1);
			Console.WriteLine(c2);
			Console.WriteLine(c3);
			Console.WriteLine(c4);

			// Operadores lógicos
			Console.WriteLine(3 > 5 && 2 == 1);



			// Estruturas Condicionais

			int x = 10;

			Console.WriteLine("Bom Dia");

			if (x < 5){
				Console.WriteLine("Boa Tarde");
			}

			Console.WriteLine("Boa Noite");


			int z = int.Parse(Console.ReadLine());

			if (z % 2 == 0)
			{
				Console.WriteLine("É par!");
			}
			else
			{
				Console.WriteLine("É ímpar!");
			}

            Console.WriteLine("Que horas são?");
			int h = int.Parse(Console.ReadLine());

			if (h < 12)
			{
				Console.WriteLine("Bom dia!");
			} else if (h < 18 && h >= 12)
			{
				Console.WriteLine("Boa Tarde!");
			}
			else
			{
				Console.WriteLine("Boa Noite!");
			}



		}

	}
}