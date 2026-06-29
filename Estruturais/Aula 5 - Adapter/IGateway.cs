namespace PadroesDeProjeto.Estruturais.Aula_5___Adapter;

public interface IGateway
{
    public void SetValor(float valor);
    public void SetParcelas(int parcelas);
    public void SetNumeroCartao(string numeroCartao);
    public void SetCvv(string cvv);
    public bool ValidarCartao();
    public bool RealizarPagamento();
}