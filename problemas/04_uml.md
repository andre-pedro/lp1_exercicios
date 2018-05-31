# UML e design de classes

_Nota:_ Alguns exercícios desta seção pedem para desenhar um diagrama UML. A
imagem contendo o diagrama, em formato PNG ou JPG, pode ser colocada
neste [_issue_](https://github.com/VideojogosLusofona/lp1_exercicios/issues/34),
a seguir às imagens que já lá estão. Basta editar o _issue_, arrastar a imagem
para dentro da caixa, copiar o URL criado para a imagem arrastada, guardar o
_issue_, e finalmente colar o URL no respetivo ficheiro Markdown da solução.


1 - Desenha o diagrama UML de classes completo para o projeto [01](04_uml/01).

> [Soluções](../solucoes/04_uml/01.md)

---

2 - Cria um projeto no Visual Studio que respeite o seguinte diagrama UML. O
projeto deve ter funcionalidade mínima para demonstrar as relações indicadas no
diagrama.

![uml02](https://user-images.githubusercontent.com/3018963/39075707-09fe48fa-44ef-11e8-9b37-461a459b5aca.png)

> [Soluções](../solucoes/04_uml/02.md)

---

3 - Considera o diagrama UML em baixo, e depois indica, justificando, quais das
seguintes instruções são válidas e quais são inválidas. As instruções são
independentes umas das outras, e naquelas que não implicam criação de objetos
presume-se que o(s) objeto(s) em questão já foram instanciados. Considera-se
que todas as instruções ocorrem fora das classes presentes no diagrama.

![uml03](https://user-images.githubusercontent.com/3018963/39089164-7c657fc0-45b8-11e8-9f73-a20edb1654c5.png)

* `Animal animal = new Dog();`
* `Cat cat = new Dog();`
* `Cat cat = new Animal();`
* `a.Bark(); // 'a' é uma instância de Animal`
* `dog.Eat(); // 'dog' é uma instância de Dog`
* `float y = tareco.energy; // 'tareco' é uma instância de Cat`
* `Console.WriteLine(myCat.Name); // 'myCat' é uma instância de Cat`
* `bobi.energy = 123.4f; // 'bobi é uma instância de Dog'`
* `Dog pluto = new Animal();`
* `y.Meow(); // 'y' é uma instância de Cat`
* `beast.Bite(); // 'beast' é uma instância de Animal`
* `zz.Eat(); // 'zz' é uma instância de Cat`

> [Soluções](../solucoes/04_uml/03.md)

---

4 - Desenha o diagrama UML de classes completo para o
[exercício 21](03_poo.md#ex21) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/04.md)

---

5 - Desenha o diagrama UML de classes (versão simplificada, apenas blocos com
nome do tipo, relações entre os tipos, e cardinalidade) para o código do
[exercício 22](03_poo.md#ex22) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/05.md)

---

6 - Desenha o diagrama UML de classes (versão simplificada, apenas blocos com
nome do tipo, relações entre os tipos, e cardinalidade) para o código do
[exercício 23](03_poo.md#ex23) de Programação por Objetos.

> [Soluções](../solucoes/04_uml/06.md)

---

7 - Considera a seguinte classe:

```cs
public abstract class NPC
{
    public float HP { get; protected set; }

    public NPC(float hp)
    {
        HP = hp;
    }

    public void PlayTurn()
    {
        if (FindEnemies())
        {
            AttackEnemies();
        }
        if (FindFood())
        {
            EatFood();
        }
        Move();
    }

    protected abstract bool FindFood();
    protected abstract bool FindEnemies();
    protected abstract void EatFood();
    protected abstract void AttackEnemies();

    protected virtual void Move()
    {
        Console.WriteLine(this.GetType() + " has moved!");
    }
}
```

Responde às seguintes questões:

1. É possível instanciar esta classe? Porquê?
2. Que métodos desta classe podem ser sobrepostos (_overridden_)? E quais os
   métodos que **não** podem ser sobrepostos?
3. Cria pelo menos 3 subclasses concretas (não abstratas), representando
   diferentes NPCs num jogo, com lógicas concretas e específicas para cada um
   deles. Os métodos `EatFood()` e `AttackEnemies()` podem consistir apenas de
   `Console.WriteLines`.
4. Cria uma classe `Program` com um método `Main()` para testar as classes
   criadas no ponto anterior. Por exemplo, criar uma ou mais instâncias de cada
   classe, colocar as mesmas numa coleção de `NPC`, percorrer a coleção, e
   invocar o método `PlayTurn()` em cada uma delas. Repara que, além do
   construtor, só o método `PlayTurn()` pode ser invocado a partir de outras
   classes.
5. Desenha o diagrama UML da solução apresentada.

> [Soluções](../solucoes/04_uml/07.md)

---

8 - O exercício anterior corresponde a um _design pattern_ muito útil e comum,
que consiste em definir os passos principais de um algoritmo ou operação,
deferindo para as subclasses alguns ou todos os passos concretos. Por outras
palavras, este _design pattern_ permite redefinir alguns passos do algoritmo ou
operação sem alterar a estrutura do mesmo. Que _design pattern_ é este?

> [Soluções](../solucoes/04_uml/08.md)

---
