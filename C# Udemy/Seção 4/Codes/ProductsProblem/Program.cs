using System;
using System.Globalization;

namespace ProductsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Produto p1 = new Produto();

            Console.WriteLine("Entre os dados do Produto:");
            
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p1);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd_add = int.Parse(Console.ReadLine());

            p1.AdicionarProdutos(qtd_add);

            Console.WriteLine($"Dados atualizados: {p1}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qtd_rem = int.Parse(Console.ReadLine());
            
            p1.RemoverProdutos(qtd_rem);
            Console.WriteLine($"Dados atualizados: {p1}");










        }
    }
}