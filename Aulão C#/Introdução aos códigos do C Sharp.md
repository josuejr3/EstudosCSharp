
#### Variáveis

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

#### Constantes

Constantes são variáveis cujo valor é mantido e nunca alterado durante a execução do programa.

```cs
const int num = 1;
```

#### I/O com C# 

Semelhante a outras linguagens, para armazenar a entrada de um usuário basta fazer um ReadLine ser atribuído a uma variável.

```cs
string name = Console.ReadLine();
Console.WriteLine("Seu nome é: ");
Console.WriteLine(name);
```

#### Operações Aritméticas

As operações aritméticas são iguais as de outras linguagens de programação. Divisão de números inteiros sempre terá um resultado inteiro. Se um dos números forem decimal o resultado será float.

```cs
int num = 10;
int resultado = num + numero;
int resultado2 = num - numero;
int resultado3 = num * numero;

var resultado4 = num / numero;

Console.WriteLine((resultado, resultado2, resultado3, resultado4));
```
