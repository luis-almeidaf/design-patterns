namespace PadroesDeProjeto.Criacionais.Aula_21___Prototype;

public class GerenciadorDePrototipos
{
    private readonly Dictionary<string, IPrototype> _prototipos = [];

    public GerenciadorDePrototipos()
    {
        var livro = new Livro();
        livro.SetNome("Desconhecido");
        livro.SetAutor("Desconhecido");
        livro.SetNumeroPaginas(0);

        _prototipos.Add("livro", livro);

        var revista = new Revista();
        revista.SetNome("Desconhecido");
        revista.SetEdicao(0);
        _prototipos.Add("revista", revista);

        var trabalho = new Trabalho();
        trabalho.SetNome("Desconhecido");
        trabalho.SetAutor("Desconhecido");
        trabalho.SetTipo("desconhecido");

        _prototipos.Add("trabalho", trabalho);
    }

    public IPrototype GetInstance(string identificador) => _prototipos[identificador].Clone();
}