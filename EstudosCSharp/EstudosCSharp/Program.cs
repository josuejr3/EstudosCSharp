using EstudosCSharp.Models;
//
// Pessoa pessoa1 = new Pessoa();
//
// pessoa1.Nome = "Josue";
// pessoa1.Idade = 24;
// pessoa1.NomeRepresentanteLegal = "JUZAS ENTERPRISE";
// pessoa1.Apresentar();
//
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);
// Console.WriteLine((dataAtual.AddDays(5).ToString("dd/MM/yyyy")));
//
// int a = 1;
// int v = 2;
// Console.WriteLine(a+v);
//
// // Casting
// // converte o valor nulo null
// int b = Convert.ToInt32("5");
// Console.WriteLine(b);
//
// int g = int.Parse("9");
// Console.WriteLine(g);
//
// // Convertendo pra string
// int inteiro = 10;
// string inteiroValor = inteiro.ToString();
//
// // conversão implicita
// int t = 0;
// double e = t;
// Console.WriteLine(e);
//
// // conversao segura
// string z = "4";
// int.TryParse(z, out g);



// Condicionais em c#

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;


if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine($"Venda Realizada {quantidadeCompra - 1}");
} else if (quantidadeEmEstoque < quantidadeCompra)
{
  Console.WriteLine("Nao tem no estoque");  
}
else
{
    Console.WriteLine("Teste");
}

// Usando Switch case

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
        Console.WriteLine("É a");
        break;
    case "b":
        Console.WriteLine("É b");
        break;
    default:
        Console.WriteLine("É diferente");
        break;
}

// Operadores lógicos são iguais aos de C/C++




























