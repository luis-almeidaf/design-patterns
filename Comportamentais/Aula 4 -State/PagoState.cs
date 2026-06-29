namespace PadroesDeProjeto.Comportamentais.Aula_4__State;

public class PagoState(PedidoState pedido) : IState
{
    public void SucessoAoPagar() => throw new Exception("Operação não suportada, o pedido já foi pago.");

    public void CancelarPedido() => pedido.SetEstadoAtual(new CanceladoState(pedido));

    public void DespacharPedido() => pedido.SetEstadoAtual(new EnviadoState(pedido));
}