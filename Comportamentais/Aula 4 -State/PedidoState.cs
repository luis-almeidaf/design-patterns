namespace PadroesDeProjeto.Comportamentais.Aula_4__State;

public class PedidoState
{
    private IState _estadoAtual;
    
    public PedidoState()
    {
        _estadoAtual = new AguardandoPagamentoState(this);
    }

    public void RealizarPagamento() => _estadoAtual.SucessoAoPagar();

    public void CancelarPedido() => _estadoAtual.CancelarPedido();
    
    public void DespacharPedido() => _estadoAtual.DespacharPedido();

    public void SetEstadoAtual(IState estadoAtual) => _estadoAtual =  estadoAtual;
}