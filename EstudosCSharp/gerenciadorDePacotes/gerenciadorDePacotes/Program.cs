// See https://aka.ms/new-console-template for more information



// cli pra adicionar o newtonsoft.json
// dotnet add package Newtonsoft.Json --version 13.0.4-beta1


// Serialização - transformar em um fluxo de bytes para transmissão  e armazenamento

using Newtonsoft.Json;
using System.Globalization;

Venda venda = new Venda(1, "Material", 25.0M);
Venda venda2 = new Venda(2, "Material2", 35.0M);

List<Venda> vendas = new List<Venda>();
vendas.Add(venda);
vendas.Add(venda2);

string serializado_list = JsonConvert.SerializeObject(vendas, Formatting.Indented);
File.WriteAllText("D:\\Josue\\Cursos\\EstudosCSharp\\EstudosCSharp\\gerenciadorDePacotes\\gerenciadorDePacotes\\vendas_list.json", serializado_list);


string serializado = JsonConvert.SerializeObject(venda, Formatting.Indented);
Console.WriteLine(serializado);

File.WriteAllText("D:\\Josue\\Cursos\\EstudosCSharp\\EstudosCSharp\\gerenciadorDePacotes\\gerenciadorDePacotes\\vendas.json", serializado);

// deserialização
string cnteudo =
    File.ReadAllText(
        "D:\\Josue\\Cursos\\EstudosCSharp\\EstudosCSharp\\gerenciadorDePacotes\\gerenciadorDePacotes\\vendas_list.json");
List<Venda> vendas2 = JsonConvert.DeserializeObject<List<Venda>>(cnteudo);


foreach (Venda v in vendas2)
{
    Console.WriteLine(v.Id);
}