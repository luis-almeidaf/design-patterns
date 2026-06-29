using PadroesDeProjeto.Estruturais.Aula_5___Adapter.Terceiros;

namespace PadroesDeProjeto.Estruturais.Aula_5___Adapter;

public class TopPagamentosAdapter(TopPagamentos topPagamentos) : IGateway
{
    private string NumeroCartao;
    private string Cvv;

    public void SetValor(float valor) => topPagamentos.SetValorTotal(valor);

    public void SetParcelas(int parcelas) => topPagamentos.SetQuantidadeParcelas(parcelas);

    public void SetNumeroCartao(string numeroCartao)
    {
        NumeroCartao = numeroCartao;

        if (Cvv is not null)
        {
            topPagamentos.SetCartao(NumeroCartao, Cvv);
        }
    } 
    
    public void SetCvv(string cvv)
    {
        Cvv = cvv;

        if (NumeroCartao is not null)
        {
            topPagamentos.SetCartao(NumeroCartao, Cvv);
        }
    }
    public bool ValidarCartao() => true;

    public bool RealizarPagamento() => topPagamentos.RealizarPagamento();
}