namespace PadroesDeProjeto.Estruturais.Aula_22___Flyweight;

public class Arvore(int x, int y, EspecieFlyweight especie)
{
    public override string ToString() => $"X: {x}, Y: {y}, Espécie: ({especie})";
}