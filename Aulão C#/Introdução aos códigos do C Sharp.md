
---
<h2 align="center" style="color: 00ff00">Variáveis em C#</h2>
Normalmente, para criarmos variáveis com C# usamos a palavra reservada *var*.

```cs
var meuTexto = "Hello World";
console.WriteLine(meuTexto);
```

Com essa forma, existem três maneiras de declarar variáveis no C#.

-  Variáveis com o tipo 

<div align="center">
<table>
<tr><th colspan="2" align="center">Tipos de Dados C#</th></tr>
<tr>
<th align="center">Int</th>
<th align="center">Número Inteiro</th>
</tr>
<tr>
<th align="center">Float</th>
<th align="center">Número de ponto flutuante</th>
</tr>
<tr>
<th align="center">Double</th>
<th align="center">Número float maior</th>
</tr>
<tr>
<th align="center">Decimal</th>
<th align="center">Número decimal</th>
</tr>
<tr>
<th align="center">Bool</th>
<th align="center">Booleano</th>
</tr>
<tr>
<th align="center">String</th>
<th align="center">Cadeia de caracteres ("")</th>
</tr>
<tr>
<th align="center">Char</th>
<th align="center">Um único caractere ('')</th>
</tr>
</table>
</div>

Em sua natureza, o C# não possui tipagem dinâmica, ou seja, uma variável não pode "alterar" o tipo de acordo com o dado que ela recebe

> *Uma observação importante é que no C# além de indicar o tipo float é necessário colocar um f no final do valor para indicar que é float mesmo.*

```cs
float velocidade = 294.48f; 
```

Testando o tipo bool com condicional ternária.

```cs
bool value = true;
string res = value ? "Verdadeiro" : "Falso";
```

-  Variáveis "sem tipo" 

Na realidade não são sem tipo, mas o próprio compilador meio que "advinha" o tipo da variável. 

```cs
var variable = 2;
```

-  Variáveis com tipagem dinâmica

Esse tipo de variável você pode alterar o tipo dela, então temos uma variável que é string virando um valor inteiro.

```cs
dynamic cor = "azul";
cor = 1;
```

---
<h2 align="center" style="color: 00ff00">Constantes em C#</h2>
Constantes são variáveis cujo valor é mantido e nunca alterado durante a execução do programa.

```cs
const int num = 1;
```

---
<h2 align="center" style="color: 00ff00">I/O com C#</h2>
Semelhante a outras linguagens, para armazenar a entrada de um usuário basta fazer um ReadLine ser atribuído a uma variável.

```cs
string name = Console.ReadLine();
Console.WriteLine("Seu nome é: ");
Console.WriteLine(name);
```

---
<h2 align="center" style="color: 00ff00">Operações Aritméticas em C#</h2>
As operações aritméticas são iguais as de outras linguagens de programação. Divisão de números inteiros sempre terá um resultado inteiro. Se um dos números forem decimal o resultado será float.

```cs
int num = 10;
int resultado = num + numero;
int resultado2 = num - numero;
int resultado3 = num * numero;

var resultado4 = num / numero;

Console.WriteLine((resultado, resultado2, resultado3, resultado4));
```

---
<h2 align="center" style="color: #00ff00">Condicionais em C#</h2>
Assim como no restante das linguagens e programação as condicionais em C# usam além do comando básico if-else também utilizam os operadores lógicos maior, menor maior ou igual e menor ou igual, diferente, igual, and, not ou o or. Lembrando que no caso desses três últimos a sintaxe utilizada é a mesma do C++, ou seja,  **II**, **&&** e **!**

-  Exemplo de um código com apenas if-else

```cs
if (10 > 200){
	Console.WriteLine("É verdade!");
}
else{
	Console.WriteLine("É falso!");
}
```

-  Exemplo de um código com if-else-if-else

```cs
if (10 > 200){
	Console.WriteLine("É verdade!");
}
else if (20 == 20){
	Console.WriteLine("São Iguais");
}
else{
	Console.WriteLine("É falso!");
}
```

<mark style="background: #BBFABBA6;">Obs: toda entrada obtida pelo *ReadLine* é uma string. Para fazer a conversão de uma entrada de um número, por exemplo usamos o Parse que é um método de int</mark>

```cs
int idade = int.Parse("123");
// Isso vai converter para o inteiro 123
// Ou
int idade = int.Parse(Console.ReadLine());
```

---
<h2 align="center" style="color: 00ff00">Funções em C#</h2>Funções basicamente também seguem o mesmo fluxo de outras liguagens, elas servem para evitar replicação de códigos. As funções servem para armazenar um trecho de código.

No C# a primeira função que encontramos é a função *Main* que é a principal e sempre é a primeira a ser chamada quando o programa C# é executado.

```cs
class Program{
	static void Main(string[] args){
		//
	}
}
```

Por enquanto, as funçõs podem ser definidas dentro do bloco *Program*. Além disso, todas as funções vão começar com *static*.

> Exemplo definindo uma função em C# e chamando na Main

```cs
class Program{
	static void Main(string[] args){
		ExibeMsg();
	}
	static void ExibeMsg(){
		Console.WriteLine("Essa é a mensagem");
	}
}
```

> Exemplo com parâmetros

```cs
class Program{
	static void Main(string[] args){
		GerarPreco(30);
	}
	static void GerarPreco(int preco){
	    Console.WriteLine(preco);
	}
}
```

> Exemplo com parâmetros e retorno

```cs
class Program{
	static void Main(string[] args){
		int value = GerarPreco(30);
	}
	static int GerarPreco(int preco){
		int valorFinal = preco + 2;
		return valorFinal;
	}
}
```

---
<h2 align="center" style="color: 00ff00">Arrays</h2>
Um array é uma "supervariável", ou seja, dentro de um array vai ter quantos valores se desejar, semelhante as outras linguagens de programação.

Em C# os arrays armazenam um único tipo de dado. Sendo assim, não é possível ter dados diferentes dentro do mesmo array.

> Sintaxe do Array em C#

```cs
string[] products = new string[5] {
	"League of Legends",
	"Lost Ark",
	"Need For Speed Unbound",
	"Path df Exile",
	"Marvel Rivals"
};
```

Basicamente essa sintaxe diz o seguinte. Uma variável do tipo array de strings chamada produtos e atirbuimos aloca um array de strings com cinco posições. Em seguida, passo os valores para o array.

> Acessando os elementos do array e fazendo a alteração

```cs
Console.WriteLine(products[2]);
products[2] = "Need For Speed Most Wanted";
```

> Outra forma de criar arrays sem necessitar alocar diretamente a memória para ele

```cs
int[] values = {1, 2, 3, 4, 5};
```

---
<h2 align="center" style="color: 00ff00">Switch</h2>
O Switch assim como no C/C++ serve basicamente para evitar o uso de ifs e elses quando se tem situações com muitas condicionais. A sintaxe é a mesma que as outras linguagens.

```cs
switch(variable){
	case 1:
		//
		break;
	case 2:
		//
		break;
	default:
		//
		break;
}
```

---
<h2 align="center" style="color: 00ff00">Enums</h2>Enum é uma das formas de criar um novo tipo de dado no programa.  O Enum é um novo tipo de dados, porém, com um número limitdo de informações. 

-  Enums são muito usados com switchs para criação de menus

> Exemplo de criação de um Enum

```cs
enum Cor { Azul, Verde, Amarelo, Vermelho };
```

O  Enum tem esse nome porque ele faz a enumeração dos itens, no exemplo acima eu teria o azul como zero, verde como um e assim por diante. Porém, eu posso alterar essa numeração usando o seguinte código.

```cs
enum Cor {Azul = 23, Verde = 1, Amarelo = 13, Vermelho = 8};
```

<p align="center" style="background: green;">
  Obs: o Enum não pode ser declarado dentro de um método no C#, ele deve estar dentro do namespace e classe.
</p>

Nesse tipo de dado as atribuições não são feitas "diretamente", ou seja.

❌ - Isso não é permitido e gera um erro.

```cs
Cor corFavorita = "Vermelha";
```

✅ - Isso já é o correto "chamando" o Vermelho do Enum cor.

```cs
Cor corFavorita = Cor.Vermelho;
```

O enum, ou pelo menos os elementos que constituem ele podem ser convertidos para o tipo inteiro já que cada elemento está associado a um número.

```cs
Console.WriteLine((int)corFavorita);
```

A conversão *"reversa"* também pode ser feita.

```cs
Console.WriteLine((Cor)2);
```

---
<h2 align="center" style="color: 00ff00">Estruturas de Repetição</h2>Atualmente o C# possui quatro estruturas de repetição. Sendo elas o *While, Do While, For e o ForEach*.

-  While - assim como em outras linguagens de programação ele executa um bloco de código enquanto a condição for verdadeira.

```cs
int contador = 0;
while (contador < 10){
	contador++;
}
```

-  Do While - é bem parecida com a While com a diferença que nessa o bloco executa pelo menos uma única vez. 

```cs
do{
	Console.WriteLine("do While!");
} while (1000 < 10);
```

-  ForEach - essa estrutura de repetição serve para percorrer arrays.

```cs
int[] numeros = {1, 2, 3, 4, 5}
foreach(int numero in numeros){
	// Para cada numero em numeros
}
```

-  For - basicamente tem a mesma sintaxe da de C++

```cs
for (int contador = 0; contador < numeros.Length - 1; contador++){
	Console.WriteLine(numeros[contador]);
}
```

---
<h2 align="center" style="color: 00ff00">Escopos</h2>
Basicamente os escopos também são iguais outras linguagens de programação. O que diferencia é que o que seria escopo global no C# é o escopo da *class Program*.

```cs
namespace HelloWorld{
	class Program{
	
		string blackBolt = "Raio Negro";
	
		static void Main(string[] args){
			//
		}
		static void ExibeMsg(){
			//
		}
	}
}
```

<p align="center" style="background: green;">
  Obs: para que eu consiga acessar uma variável global em funções static, como é o caso da main, a variável também precisa ser static.
</p>
---
