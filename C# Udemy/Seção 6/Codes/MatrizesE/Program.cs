using System;
using System.Xml;

namespace MatrizesE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int dim = int.Parse(Console.ReadLine()!);
            int[,] mat = new int[dim, dim];

            for (int i = 0; i < dim; i++){
                string[] lines = Console.ReadLine()!.Split(' ');
                for (int j = 0; j < dim; j++){
                    mat[i, j] = int.Parse(lines[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            
            int countNegativeNumbers = 0;

            for (int i = 0; i < dim; i++){
                for (int j = 0; j < dim; j++){
                    if (mat[i, j] < 0){
                        countNegativeNumbers += 1;
                    }
                    if (i == j){
                        Console.Write(mat[i, i] + " ");
                    }
                }
            }
            Console.WriteLine($"\nNegative numbers = {countNegativeNumbers}");
        }
    }
}