namespace PadroesDeProjeto.Estruturais.Aula_16___Composite;

public class Pasta(string nome, string caminho) : Component
{
    private string Nome { get; set; } = nome;
    private string Caminho { get; set; } = caminho;
    private readonly List<Component> _components = [];

    public override void Adicionar(Component component) => _components.Add(component);

    public override void Remover(Component component)
    {
        foreach (var c in _components.ToList())
            if (c == component)
                _components.Remove(c);
    }

    public override Component RecuperarFilho(int indice) => _components[indice];

    public override void Exibir(int nivel = 0)
    {
        Console.WriteLine($"{new string(' ', nivel * 2)}## {Nome}");

        foreach (var c in _components)
            c.Exibir(nivel + 1);
    }

    public override string GetNome() => Nome;

    public override string GetCaminho() => Caminho;
}