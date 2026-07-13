namespace PadroesDeProjeto.Estruturais.Aula_16___Composite;

public class Arquivo(string nome, string caminho) : Component
{
    private string Nome { get; set; } = nome;
    private string Caminho { get; set; } = caminho;

    public override void Exibir(int nivel = 0) => Console.WriteLine($"{new string(' ', nivel * 2)}- {Nome}");

    public override string GetNome() => Nome;

    public override string GetCaminho() => Caminho;
}