namespace PadroesDeProjeto.Estruturais.Aula_5___Adapter;

public class Cobranca(IGateway gateway)
{
    private IGateway _gateway = gateway;

    public void SetGateway(IGateway gateway) => _gateway = gateway;
    
    public void SetValor(float valor) => _gateway.SetValor(valor);

    public void SetParcelas(int parcelas) => _gateway.SetParcelas(parcelas);
    
    public void SetNumeroCartao(string numeroCartao) => _gateway.SetNumeroCartao(numeroCartao);
    
    public void SetCvv(string cvv) => _gateway.SetCvv(cvv);

    public bool RealizarPagamento()
    {
        if (_gateway.ValidarCartao())
        {
            return _gateway.RealizarPagamento();
        }
        return false;
    }
}