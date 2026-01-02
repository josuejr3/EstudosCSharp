
#### O que seria uma solução no contexto do C#?

Uma solução é algo do Visual Studio que é como se fosse um gerenciador de projetos. Exemplo que criamos aula passada com o HelloWorld. Dentro da solução podemos ter quantos projetos se desejar.

<div align="center">
<img src="Gerenciador de Projetos.png" align="center">
</div>

#### Estrutura básica de um programa C# 

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
```

> Destrinchando o código temos o seguinte

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
```

Primeiro temos os módulos ou pacotes, são os "imports" do Python.

-  System - possibilita o C# manipular coisas do SO do usuário;
-  System.Collection.Generic - possui algumas estruturas de dados;
-  System.Linq - usado para quando se trabalha com muitos dados;
-  System.Text - permite manipular textos;
-  System.Threading.Tasks - trabalha com threads.

Para importar novos módulos basta usar a palavra reservada *~={cyan}Using=~*

```cs
using System.IO;  // Para manipulação de arquivos
using System.Net; // Interagir com Redes
```

