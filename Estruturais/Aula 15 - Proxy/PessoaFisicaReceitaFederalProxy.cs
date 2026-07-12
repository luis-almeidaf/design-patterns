namespace PadroesDeProjeto.Estruturais.Aula_15___Proxy;

public class PessoaFisicaReceitaFederalProxy(string cpf) : IReceitaFederal
{
    private string Cpf { get; set; } = cpf;
    private IReceitaFederal? PessoaFisicaRf { get; set; } = null;

    private void CriarPessoaFisicaReceitaFederal()
    {
        if (PessoaFisicaRf is null)
            PessoaFisicaRf = new PessoaFisicaReceitaFederal(Cpf);
    }

    public string GetNome()
    {
        CriarPessoaFisicaReceitaFederal();
        return PessoaFisicaRf!.GetNome();
    }

    public int GetIdade()
    {
        CriarPessoaFisicaReceitaFederal();
        return PessoaFisicaRf!.GetIdade();
    }

    public bool CpfAtivo()
    {
        CriarPessoaFisicaReceitaFederal();
        return PessoaFisicaRf!.CpfAtivo();
    }
}