namespace PadroesDeProjeto.Estruturais.Aula_15___Proxy;

public class Usuario(string nome, string cpf, int idade)
{
    private string _nome = nome;
    private string _cpf = cpf;
    private int _idade = idade;
    private IReceitaFederal _pessoaFisica = new PessoaFisicaReceitaFederalProxy(cpf);

    public bool ValidarNome() => _nome == _pessoaFisica.GetNome();

    public bool VerificarCpfAtivo() => _pessoaFisica.CpfAtivo();

    public bool VerificarMaioridade() => _idade >= 18 && _idade == _pessoaFisica.GetIdade();

    public string GetNome() => _nome;

    public string GetCpf() => _cpf;

    public int GetIdade() => _idade;
}