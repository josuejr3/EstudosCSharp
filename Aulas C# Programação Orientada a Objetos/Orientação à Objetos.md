
<div><h1 align="center" style="color: #00ff00">Classes e Objetos</h1></div>Uma classe é um tipo de dados compostos por membros. Uma classe vai ter propriedades que são os dados que compõe e métodos que são as funções da classe.
<br>
-  Modificador da classe - define a visibilidade da classe
	-  public - sem restrição de visualização
	-  abstract - classe-base para outras classes, não possui objetos instanciados
	-  sealed - classe não pode ser herdada
	-  static - classe não permite instanciação de objetos e seus membros devem ser static

```txt
[ModificadorClasse] class NOME_DA_CLASSE{
	// Variáveis - propriedades
	[EspecificadorAcesso] tipo NOME_PROPRIEDADE;
	
	// Métodos
	[EspecificadorAcesso] retorno NOME([arg1,...]){
		// Corpo método
	}
}
```

-  Especificador de acesso - onde um membro da classe pode ser acessado.
	-  public - sem restrição de acesso
	-  private - só podem ser acessados pela própria classe
	-  protected - podem ser acessados na própria classe e nas derivadas
	-  abstract - os métodos não tem implementação somente os cabeçalhos
	-  selead - o método não pode ser redefinido
	-  virtual - o método pode ser redefinido em uma classe derivada
	-  static - o método pode ser chamado mesmo sem a instaciação de um objeto

<p align="center" style="background: green;">
Método Construtor - é basicamente quem inicializa as propriedades da classe. Ele é definido com o mesmo nome da classe.
</p>
> Exemplo de um Construtor 

```cs
public Player(string name) {  
    Age = 23;  
    IsActive = true;  
    Name = name;  
}
```

Os construtores podem ser sobrecarregados, para isso acontecer basta só alterar os parâmetros que ele irá receber.

```cs
// Exemplo com dois construtores
public Player(string name) {  
    Age = 23;  
    IsActive = true;  
    Name = name;  
}
public Player(){}
```
<p align="center" style="background: green;">
Método Destrutor - é responsável por limpar o espaço da memória que o objeto estava usando após não ser mais necessário.
</p>
> Exemplo de um Destrutor

```cs
~Player() {  
    Console.WriteLine("Destroyed");  
}
```

---
<div><h1 align="center" style="color: #00ff00">Classes Static</h1></div>Classes static não permitem a instanciação de objetos. Elas também não permitem ter construtores, pois esse tipo de classe usa uma posição fixa na memória. 

-  Em classes static todas as propriedades e os métodos também devem ser static
-  Uma classe não static pode ter membros static
-  Em C# o método Main é sempre static.

Uma coisa importante quando estamos trabalho com classes static é que se a classe possuir atributos, como uma classe static não pode instanciar, os atributos só são acessados através da própria classe.

> Exemplo

```cs
class Player{
	static int Age = 10;
}

class Program{
	static void Main(){
		Player p1 = new Player();
		Console.WriteLine(Player.Age);
	}
}
```

Nesse caso, qualquer instância da classe player teria a mesma *Age*, pois ele é um atributo static, ou seja, é como se ele fosse um atributo da classe geral. Por esse motivo usamos **Player.Age**.

No C# o This é uma referência ao objeto. Ele é usado quando os parâmetros são iguais aos atributos da classe.

```cs
class Calculus{
	public int v1;
	public int v2;
	
	public Calculus(int v1, int v2){
		this.v1 = v1;
		this.v2 = v2;
	}
}
```

