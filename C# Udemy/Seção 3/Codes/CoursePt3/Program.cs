using System;
using System.Globalization;


namespace CoursePt3
{
	internal class Program
	{

		static void Main(string[] args)
		{


			//Console.Write("Digite um número: ");
			//double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			//while (x >= 0)
			//{
			//double raiz = Math.Sqrt(x);
			//Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
			//Console.Write("Digite um número: ");
			//x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			//}

			//Console.WriteLine("Número negativo");

			Console.Write("Quantos números inteiros você vai digitar? ");
			int n = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = 1; i <= n; i++)
			{
                Console.Write($"Valor #{i}: ");
				int value = int.Parse(Console.ReadLine());
				sum += value;
			}

			Console.WriteLine($"Soma = {sum}");

			

		}

		static int Maior(int a, int b, int c)
		{
			int m;

			if (a > b && a > c)
			{
				m = a;
			}
			else if (b > c)
			{
				m = b;
			}
			else
			{
				m = c;
			}
			return m;
		}



	}
}