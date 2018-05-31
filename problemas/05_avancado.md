# Tópicos avançados de C#

1 - Escreve um método `static` que troque o valor de duas variáveis de entrada
cujo tipo é definido em tempo de execução (ou seja, por quem invoca o método).

> [Soluções](../solucoes/05_avancado/01.md)

---

2 - Cria uma classe `IntList` que estende `List<int>`, adicionando três versões
de um método que retorne o valor mínimo (`int`), o valor máximo (`int`) e o
valor médio (`float`) referentes aos inteiros contidos na lista. Cada versão do
método deve retornar estes valores de forma diferente: 1) usando parâmetros de
saída (`out`); 2) usando uma classe/_struct_ específica; e, 3) usando tuplos. A
segunda forma pressupõe a criação de uma classe ou _struct_ extra; neste caso
podem criar uma classe/_struct_ interna, ou seja, dentro da classe `IntList`.
Sobrepõe ainda o método `ToString()` de modo a que a _string_ devolvida indique
quantos elementos tem a lista, bem como os valores mínimo, máximo e médio
contidos na mesma.

> [Soluções](../solucoes/05_avancado/02.md)

---

3 - Cria uma classe chamada `HighScoreManager`, que contém internamente uma
coleção com um máximo de 10 `Tuple<string, float>`, cada um representando o
nome de um jogador e o respetivo _score_. Além da coleção referida, a classe
deve ainda conter:

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

5 - Cria uma classe, com **um único** método estático `Main()`, que solicita ao
utilizador um número inteiro positivo e apresenta o respetivo número da
[sequência de Lucas](https://en.wikipedia.org/wiki/Lucas_number). Este número
é tipicamente calculado de forma recursiva, e para o efeito podem usar funções
locais.

> [Soluções](../solucoes/05_avancado/05.md)

---

6 - Considera o seguinte método:

```cs
public void AwesomeMethod(float a, float b, int c = 2, string d = "hi!")
{
    Console.WriteLine($"{a} {b} {c} {d}");
}
```

1. Quais os parâmetros obrigatórios?
2. Quais os parâmetros opcionais?
3. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(-1.0f, 0.0f, d: "bye!")`?
4. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(50, -10, 14)`?
5. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(c: 100, b: 123f, d: "yeah!", a: 0)`?
5. Qual o valor de `a`, `b`, `c` e `d` se método for invocado da seguinte
forma: `AwesomeMethod(b: 1, a: 2)`?

> [Soluções](../solucoes/05_avancado/06.md)

---

7 - Cria uma classe estática chamada `Stats` com vários métodos utilitários
para determinar estatísticas simples. Cada um destes métodos deve aceitar um
número variável de _doubles_ e retornar o valor estatístico que lhe compete.
Devem existir métodos para a retornar a média, mediana, moda, máximo e mínimo.

Cria também uma classe `Program` com um método `Main()` para testar os vários
métodos da classe `Stats`.

> [Soluções](../solucoes/05_avancado/07.md)

---

8 - Adiciona dois método à classe criada no exercício anterior:

1. O primeiro retorna todas as estatísticas de um número variável de _doubles_
   (média, mediana, moda, máximo e mínimo) num tuplo.
2. O segundo retorna todas as estatísticas de um número variável de _doubles_
   (média, mediana, moda, máximo e mínimo) em parâmetros `out`.

Ambos os métodos devem fazer uso dos métodos já existentes para cálculo das
estatísticas.

Atualiza o método `Main()` da classe `Program` para testar os dois métodos
novos.

> [Soluções](../solucoes/05_avancado/08.md)

---

9 - Responde às seguintes questões:

1. Nos métodos, os parâmetros opcionais têm de aparecer a seguir a todos
   os parâmetros obrigatórios?
2. Num método, um parâmetro com a _keyword_ `params` tem de ser o último?
3. Dado o método
   `void AwesomeMethod(float x, int y = 2, params double[] z) {...}`, quais das
   seguintes instruções são válidas? Em caso afirmativo, quais os conteúdos de
   `x`, `y` e `z`?


* `AwesomeMethod(a: 2.1f, 3, 12, 23f, 34.5, -123.0);`
* `AwesomeMethod(1.7f);`
* `AwesomeMethod();`
* `AwesomeMethod(0.01f, z: new double[] { 2.3, 4, -4f });`
* `AwesomeMethod(0, 2.3f, 2, 3, 4, 5);`
* `AwesomeMethod(-1.9f, 2, 3.0, 4.0, 5.0, 6.0, 19, -1, 4);`


> [Soluções](../solucoes/05_avancado/09.md)

---

10 - Quais as vantagens e desvantagens do uso de `out` e `ref` na passagem de
parâmetros para métodos?

> [Soluções](../solucoes/05_avancado/10.md)

---

11 - Qual a diferença entre `out` e `ref` na passagem de parâmetros para
métodos?

> [Soluções](../solucoes/05_avancado/11.md)

---

12 - Responde Sim/Não às seguintes questões:

1. Um parâmetro `out` indica que foi passada uma referência para a própria
variável em vez de uma cópia da mesma?
2. Um parâmetro `ref` indica que foi passada uma referência para a própria
variável em vez de uma cópia da mesma?
3. Os parâmetros `out` têm de ser inicializados dentro do método?
4. Os parâmetros `ref` têm de ser inicializados dentro do método?

> [Soluções](../solucoes/05_avancado/12.md)

---

13 - Escreve um programa que aceita _strings_ escritas pelo utilizador em
_loop_, gravando as mesmas convertidas em maiúsculas num ficheiro especificado
como argumento da linha de comandos. O programa termina quando o utilizador
insere uma _string_ vazia (isto é, simplesmente pressiona ENTER sem escrever
nada).

_Sugestão_: confere o método [ToUpper()](https://docs.microsoft.com/pt-pt/dotnet/api/system.string.toupper)
da classe [string](https://docs.microsoft.com/pt-pt/dotnet/api/system.string).

> [Soluções](../solucoes/05_avancado/13.md)

---

14 - Escreve um programa que aceita _strings_ escritas pelo utilizador em
_loop_ e tenta converte-las em `byte`. Em caso de sucesso mostra uma mensagem
apropriada contendo o valor convertido. Em caso de falhanço, mostra uma
mensagem com indicação desse facto. O programa termina quando o utilizador
insere uma _string_ vazia (isto é, simplesmente pressiona ENTER sem escrever
nada).

> [Soluções](../solucoes/05_avancado/14.md)

---
