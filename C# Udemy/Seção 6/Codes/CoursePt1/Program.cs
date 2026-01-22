using System;
using System.Globalization;

namespace CoursePt1
{
    internal class Program
    {
        static void Main(string[] args){
            
        
            // double? x = null;
            // double? y = 10.0;

            // Console.WriteLine(x.GetValueOrDefault());
            // Console.WriteLine(y.GetValueOrDefault());

            // Console.WriteLine(x.HasValue);
            // Console.WriteLine(y.HasValue);

            // double a = x ?? 5;
            // double b = y ?? 5;

            // Console.WriteLine($"A = {a}");
            // Console.WriteLine($"B = {b}");            


            // Console.WriteLine("START");

            // int n = int.Parse(Console.ReadLine()!);
            // double[] vect = new double[n];

            // for (int i = 0; i < n; i++){
            //     vect[i] = double.Parse(Console.ReadLine());
            // }
            
            // for (int i = 0; i < n; i++){
            //     Console.WriteLine(vect[i]);

            // }


            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            double media = 0.0;

            for (int i = 0; i < n; i++)
            {
                
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product();
                vect[i].Name = nome;
                vect[i].Price = preco;
                media += vect[i].Price;

            }

            media = media / n;
            Console.Write($"AVARAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");









        }
    }
}