using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(1, "José");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        
            Console.WriteLine(list.Count);

            // Encontrando primeira ocorrência de nome que começa com A
            string s1 = list.Find(Test);
            Console.WriteLine("First A: " + s1);

            // string s1 = list.Find(x => x[0] == 'A');

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            List<string> resultado = list.FindAll(x => x.Length == 5);

            foreach (string obj in resultado)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            list.RemoveAt(2);

            Console.WriteLine("===================");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }


    }
}