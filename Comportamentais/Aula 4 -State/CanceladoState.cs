namespace PadroesDeProjeto.Comportamentais.Aula_4__State;

public class CanceladoState(PedidoState pedido) : IState
{
    public void SucessoAoPagar() => throw new Exception("Operação não suportada, o pedido já foi cancelado.");
    
    public void CancelarPedido() => throw new Exception("Operação não suportada, o pedido já foi cancelado.");
    
    public void DespacharPedido() => throw new Exception("Operação não suportada, o pedido já foi cancelado.");
}