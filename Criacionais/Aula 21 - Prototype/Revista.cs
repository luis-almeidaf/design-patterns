namespace PadroesDeProjeto.Criacionais.Aula_21___Prototype;

public class Revista : IPrototype
{
    private string Nome { get; set; } = null!;
    private int Edicao { get; set; }

    public string SetNome(string nome) => Nome = nome;

    public void SetEdicao(int edicao) => Edicao = edicao;

    public override string ToString() => "Revista " + Nome + " " + Edicao;

    public IPrototype Clone() => new Revista
    {
        Edicao = Edicao,
        Nome = Nome
    };
}