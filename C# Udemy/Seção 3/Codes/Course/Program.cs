using System;
using System.Globalization;

namespace Course
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// SByte x = 100;
			// Console.WriteLine(x);

			int n2 = 1000;
			int n3 = 2147483647;
			long n4 = 2147483648L;

			byte n1 = 4;
			Console.WriteLine(n1);
            Console.WriteLine(n4);
            Console.WriteLine(n3);

			bool completo = false;
			char genero = 'F';
			char letra = '\u0041';
			float n5 = 4.5f;

			// string nome = "João";

			// Objeto genérico
			object obj1 = "Alex Brown";

			Console.WriteLine(completo);
			Console.WriteLine(genero);
			Console.WriteLine(letra);
			Console.WriteLine(n5);
			// Console.WriteLine(nome);

            // Valor minimo do int
            Console.WriteLine(int.MinValue);
            Console.WriteLine(decimal.MaxValue);

			float numero = 5.69389f;
			Console.WriteLine(numero.ToString("F1", CultureInfo.InvariantCulture));


			// SAIDAS

			int idade = 32;
			double saldo = 10.35784;
			string nome = "Maria";

			// SAIDAS COM PLACEHOLDERS

			Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
			Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
			Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

			// Operadores de Atriuição

			Console.WriteLine(idade += 3);
			Console.WriteLine(idade);


			// Conversão implicita
			//float x = 4.5f;
			//double y = x;

			// Conversao explicita
			//double a;
			//float b;

			//a = 5.1;
			//b = (float)a;

			//Console.WriteLine(b);

			double a = 1.0, b = -3.0, c = -4.0;
			double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

			double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
			double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

			Console.WriteLine($"O delta é {delta}");


			string frase = Console.ReadLine();
			Console.WriteLine("Você digitou " + frase);

			string x = Console.ReadLine();
			string y = Console.ReadLine();
			string z = Console.ReadLine();

			Console.WriteLine("Você digitou " + x);
			Console.WriteLine("Você digitou " + y);
			Console.WriteLine("Você digitou " + z);


			string s = Console.ReadLine();
			string[] vet = s.Split(' ');


			Console.WriteLine(vet.Length);




			// Lendo um inteiro
			int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1.GetType());

			













		}
	}
}