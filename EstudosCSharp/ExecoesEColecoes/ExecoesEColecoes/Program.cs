//
// Stack<int> pilha = new Stack<int>();
//
// pilha.Push(5);
// pilha.Push(6);
// pilha.Push(7);
// pilha.Push(8);
// pilha.Pop();
//
// try
// {
//     string[] linhas =
//         File.ReadAllLines(
//             "D:\\Josue\\Cursos\\EstudosCSharp\\EstudosCSharp\\ExecoesEColecoes\\ExecoesEColecoes\\arquivosLeitura\\arquivoLeitura.txt");
//
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"erro ne {ex.Message}");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"erro ne {ex.Message}");
// }
// finally
// {
//     Console.WriteLine($"acabo");
//     throw new Exception("erro acabo");   
// }

// Dicionarios

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("PB", "Paraíba");

foreach (var item in estados)
{
    Console.WriteLine(item.Key + " - " + item.Value);
}

estados.Remove("SP");
estados["PB"] = "PB - ALTERADO";

foreach (var item in estados)
{
    Console.WriteLine(item.Key + " - " + item.Value);
}

if (estados.ContainsKey("PB"))
{
    Console.WriteLine(estados["PB"]);
}

// TUPLAS

(int, string, string, decimal) tupla = (1, "Josue", "Junior", 45.5M);
Console.WriteLine($"{tupla.Item1} - {tupla.Item2}");

// TUPLAS OUTRA SINTAXE
ValueTuple<int, string, string, decimal> outroExemplo = (1, "Josue", "Junior", 45.5M);
var outroExemploTuplaCreate = Tuple.Create(1, "Josue", "Junior", 45.5M);

// Tuplas podem ser usadas para retornar "mais de uma coisa"
// Se nao quisermos todos os valores de uma tupla podemos descartar usando _

// O destrutor separa os dados que o construtor uniu

// if ternario
bool ehPar = true;
Console.WriteLine((ehPar ? "sim" : "nao"));












