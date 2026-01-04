
<div><h1 align="center" style="color: #00ff00">Classes e Objetos</h1></div>Uma classe é um tipo de dados compostos por membros. Uma classe vai ter propriedades que são os dados que compõe e métodos que são as funções da classe.

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

> Método Construtor - é basicamente quem inicializa as propriedades da classe. Ele é definido com o mesmo nome da classe.

