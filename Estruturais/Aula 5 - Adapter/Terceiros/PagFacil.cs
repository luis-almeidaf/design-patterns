namespace PadroesDeProjeto.Estruturais.Aula_5___Adapter.Terceiros;

public class PagFacil
{
    private float Valor;
    private int Parcelas;
    private string NumeroCartao;
    private string Cvv;
    
    public void SetValor(float valor) => Valor = valor;
    
    public void SetParcelas(int parcelas) => Parcelas = parcelas;

    public void SetNumeroCartao(string numeroCartao) => NumeroCartao = numeroCartao;

    public void SetCvv(string cvv) => Cvv = cvv;

    public bool ValidarCartao() => NumeroCartao != "" || Cvv != "" && Cvv.Length == 3;

    public bool RealizarPagamento()
    {
        Console.WriteLine("Pagamento realizado via PagFacil");
        return true;
    }
}