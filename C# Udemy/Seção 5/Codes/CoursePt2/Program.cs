using System;
using CoursePt2;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 900.00, 10);
            Console.WriteLine(p.Nome);

            p.Nome = "TV 4k";
            Console.WriteLine(p.Nome);


        }
    }
}