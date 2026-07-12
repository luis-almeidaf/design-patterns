namespace PadroesDeProjeto.Estruturais.Aula_15___Proxy;

public class PessoaFisicaReceitaFederal : IReceitaFederal
{
    private readonly string _nome;
    private string _cpf;
    private readonly int _idade;
    private readonly bool _cpfAtivo;

    public PessoaFisicaReceitaFederal(string cpf)
    {
        _nome = "Luis";
        _cpf = cpf;
        _idade = 33;
        _cpfAtivo = true;
        Thread.Sleep(5000);
        Console.WriteLine("PessoaFisicaReceitaFederal criada com sucesso!");
    }

    public PessoaFisicaReceitaFederal(string cpf, string nome, int idade, bool cpfAtivo)
    {
        _nome = nome;
        _cpf = cpf;
        _idade = idade;
        _cpfAtivo = cpfAtivo;
        Thread.Sleep(5000);
        Console.WriteLine("PessoaFisicaReceitaFederal criada com sucesso!");
    }

    public string GetNome()
    {
        Thread.Sleep(2000);
        return _nome;
    }

    public int GetIdade()
    {
        Thread.Sleep(2000);
        return _idade;
    }

    public bool CpfAtivo()
    {
        Thread.Sleep(2000);
        return _cpfAtivo;
    }
}