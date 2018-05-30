# Tópicos avançados de C#

1 - Escreve um método `static` que troque o valor de duas variáveis de entrada
cujo tipo é definido em tempo de execução (ou seja, por quem invoca o método).

> [Soluções](../solucoes/05_avancado/01.md)

---

2 - Cria uma classe `IntList` que estende `List<int>`, adicionando três métodos
que retornam o valor mínimo (`int`), o valor máximo (`int`) e o valor médio
(`float`) referentes aos inteiros contidos na lista. Os três métodos devem
retornar estes valores de forma diferente: 1) usando parâmetros de saída
(`out`); 2) usando uma classe/_struct_ específica; e, 3) usando tuplos. A
segunda formas pressupõe a criação de uma classe ou _struct_ extra; neste caso
podem criar uma classe/_struct_ interna, ou seja, dentro da classe `IntList`.
Sobrepõe ainda o método `ToString()` de modo a que a _string_ devolvida indique
quantos elementos tem a lista, bem como os valores mínimo, máximo e médio
contidos na mesma.

> [Soluções](../solucoes/05_avancado/02.md)

---

3 - Cria uma classe chamada `HighScoreManager`, que contém internamente uma
coleção com um máximo de 10 `Tuple<string, float>`, representando nomes de
jogadores e os respetivos _scores_. Além da coleção referida, a classe deve
ainda conter:

* Um construtor, que aceita opcionalmente um nome de ficheiro (deve existir
  um nome por omissão), e:
  * Caso o ficheiro não exista, inicializa a coleção sem elementos.
  * Caso o ficheiro exista, abre-o e inicializa a coleção de modo a que
    contenha os nomes e _scores_ especificados no ficheiro.
  * Caso o ficheiro exista, mas tenha um formato inválido, lançar uma excepção
    do tipo `InvalidOperationException`.
* Um método `AddScore(string name, float score)`, que adiciona um novo
  `Tuple<string, float>` à coleção. Se o número de _scores_ ultrapassar 10, o
  tuplo contendo o menor _score_ deve ser removido.
* Um método `Save()`, que guarda os _scores_ no ficheiro especificado no
  construtor.
* Um método `ToString()`, que devolve uma _string_ contendo uma tabela
  devidamente formatada com todos os nomes e _scores_, do mais alto ao mais
  baixo.
* Um método iterável `GetScores()` que retorna de forma ordenada (do _score_
  mais alto até ao _score_ mais baixo) todos tuplos guardados na coleção.

O formato do ficheiro de _high scores_ fica ao critério dos alunos.

Cria também uma classe `Program` com um método `Main` para testar os vários
métodos da classe `HighScoreManager`.

> [Soluções](../solucoes/05_avancado/03.md)

---

4 - De modo a que o seguinte código passe a funcionar é necessário adicionar
algumas linhas antes do mesmo. Quais são?

```cs
class Program
{
    public static void Main()
    {
        float number;
        WriteLine("Escreve um número: ");
        number = ToSingle(ReadLine());
        WriteLine("O coseno desse número é {0:f3}", Cos(number));
    }
}
```

> [Soluções](../solucoes/05_avancado/04.md)

---
