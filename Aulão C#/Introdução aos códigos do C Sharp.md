
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