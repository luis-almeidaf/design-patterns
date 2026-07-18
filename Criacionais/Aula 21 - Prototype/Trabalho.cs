namespace PadroesDeProjeto.Criacionais.Aula_21___Prototype;

public class Trabalho : IPrototype
{
    private string Nome { get; set; } = null!;
    private string Autor { get; set; } = null!;
    private string Tipo { get; set; } = null!;

    public string GetNome() => Nome;

    public void SetNome(string nome) => Nome = nome;

    public string GetAutor() => Autor;

    public void SetAutor(string autor) => Autor = autor;

    public string GetTipo() => Tipo;

    public void SetTipo(string tipo) => Tipo = tipo;

    public override string ToString() => "Trabalho " + Nome + " " + Autor + " " + Tipo;

    public IPrototype Clone() => new Trabalho
    {
        Nome = Nome,
        Autor = Autor,
        Tipo = Tipo
    };
}