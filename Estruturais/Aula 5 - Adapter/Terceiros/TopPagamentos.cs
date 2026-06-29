namespace PadroesDeProjeto.Estruturais.Aula_5___Adapter.Terceiros;

public class TopPagamentos
{
    private float Valor;
    private int Parcelas;
    private string NumeroCartao;
    private string Cvv;
    
    public void SetValorTotal(float valorTotal) => Valor = valorTotal;
    
    public void SetQuantidadeParcelas(int parcelas) => Parcelas = parcelas;

    public void SetCartao(string numeroCartao, string cvv)
    {
        NumeroCartao = numeroCartao;
        Cvv = cvv;
    }
    
    public bool RealizarPagamento()
    {
        Console.WriteLine("Pagamento realizado via TopPagamentos");
        return true;
    }
}