using System;

// O metodo main só é necessário do .net5.0 pra baixo
// Do .net6.0 em diante o código pode ser feito "direto"

namespace EstudosCSharp
{
    class Program
    {
        internal static void Main(string[] args)
        {
            // Usando vetores
            int[] arrayInteiros = new int[3];

            for (int cont = 0; cont < arrayInteiros.Length ; cont++)
            {
                arrayInteiros[cont] = cont;
            }

            foreach (int value in arrayInteiros)
            {
                Console.WriteLine($"Valor: {value}");
            }
            
            // Redimensionando array
            Array.Resize(ref arrayInteiros, arrayInteiros.Length + 2);
            // Copiando array
            int[] arrayDobrado = new int[arrayInteiros.Length * 2];
            Array.Copy(arrayInteiros, arrayDobrado, arrayInteiros.Length);
            
            // Instanciando Listas
            List<string> listaString = new List<string>();
            listaString.Add("A");
            listaString.Add("B");
            listaString.Add("C");

            foreach (string value in listaString)
            {
                Console.WriteLine(value);
            }
            
            
        }
    }
}