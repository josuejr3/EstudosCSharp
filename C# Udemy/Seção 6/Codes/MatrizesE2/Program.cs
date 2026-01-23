using System;

namespace MatrizE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] dim_matriz = Console.ReadLine()!.Split(' ');
    
            int linha = int.Parse(dim_matriz[0]);
            int coluna = int.Parse(dim_matriz[1]);

            int[,] mat = new int[linha, coluna];

            for (int i = 0; i < linha; i++){
                string[] cols = Console.ReadLine()!.Split(' ');
                for (int j = 0; j < coluna; j++){
                    mat[i, j] = int.Parse(cols[j]);
                }
            }        
            

            int valueSearch = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < linha; i++){
                for (int j = 0; j < coluna; j++){
                    
                    if (mat[i,j] == valueSearch){

                        Console.WriteLine($"Position: {i},{j}:");

                        if (i == 0){
                            if (j == 0){
                                Console.WriteLine($"Right: {mat[i, j+1]}");
                                Console.WriteLine($"Down: {mat[i+1, j]}");
                            } else if (j == (coluna - 1)){
                                Console.WriteLine($"Left: {mat[i, j-1]}");
                                Console.WriteLine($"Down: {mat[i+1, j]}");
                            }
                            else{
                                Console.WriteLine($"Right: {mat[i, j+1]}");
                                Console.WriteLine($"Left: {mat[i, j-1]}");
                                Console.WriteLine($"Down: {mat[i+1, j]}");
                            }
                        } else if (i == (linha-1)){
                            if (j == 0){
                                Console.WriteLine($"Right: {mat[i, j+1]}");
                                Console.WriteLine($"Up: {mat[i-1, j]}");
                            } else if (j == (coluna - 1)){
                                Console.WriteLine($"Left: {mat[i, j-1]}");
                                Console.WriteLine($"Up: {mat[i-1, j]}");
                            }
                            else{
                                Console.WriteLine($"Left: {mat[i, j-1]}");
                                Console.WriteLine($"Right: {mat[i, j+1]}");
                                Console.WriteLine($"Up: {mat[i-1, j]}");
                            }
                        }
                        else{
                            Console.WriteLine($"Up: {mat[i-1, j]}");
                            Console.WriteLine($"Down: {mat[i+1, j]}");
                            if (j == 0){
                                Console.WriteLine($"Right: {mat[i, j+1]}");
                            } else if (j == (coluna - 1)){
                                Console.WriteLine($"Left: {mat[i, j-1]}");
                            }
                            else{
                                Console.WriteLine($"Right: {mat[i, j+1]}");
                                Console.WriteLine($"Left: {mat[i, j-1]}");
                            }
                        }   
                    }
                }
            }  

        }
    }
}