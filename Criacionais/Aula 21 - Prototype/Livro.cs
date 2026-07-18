namespace PadroesDeProjeto.Criacionais.Aula_21___Prototype;

public class Livro() : IPrototype
{
    private string Nome { get; set; } = null!;
    private string Autor { get; set; } = null!;
    private int NumeroPaginas { get; set; }

    public string GetNome() => Nome;

    public void SetNome(string nome) => Nome = nome;

    public string GetAutor() => Autor;

    public void SetAutor(string autor) => Autor = autor;

    public int GetNumeroPaginas() => NumeroPaginas;

    public void SetNumeroPaginas(int numeroPaginas) => NumeroPaginas = numeroPaginas;

    public override string ToString() => "Livro: " + Nome + " " + Autor + " " + NumeroPaginas;

    public IPrototype Clone() => new Livro
    {
        Nome = Nome,
        Autor = Autor,
        NumeroPaginas = NumeroPaginas
    };
}