namespace PadroesDeProjeto.Comportamentais.Aula_4__State;

public class AguardandoPagamentoState(PedidoState pedido) : IState
{
    public void SucessoAoPagar() => pedido.SetEstadoAtual(new PagoState(pedido));

    public void CancelarPedido() => pedido.SetEstadoAtual(new CanceladoState(pedido));

    public void DespacharPedido() => throw new Exception("Operação não suportada, o pedido ainda não foi pago");
}