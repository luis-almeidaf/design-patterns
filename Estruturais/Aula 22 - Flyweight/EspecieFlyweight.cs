namespace PadroesDeProjeto.Estruturais.Aula_22___Flyweight;

public class EspecieFlyweight(string nome, string cor, float alturaMaxima)
{
    public string Nome { get; } = nome;
    public string Cor { get; } = cor;
    public float AlturaMaxima { get; } = alturaMaxima;

    public override string ToString() => $"Nome: {Nome}, Cor: {Cor}, Altura Máxima: {AlturaMaxima}";
}