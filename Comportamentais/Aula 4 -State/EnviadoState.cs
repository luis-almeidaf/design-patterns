namespace PadroesDeProjeto.Comportamentais.Aula_4__State;

public class EnviadoState(PedidoState pedido) : IState
{
    public void SucessoAoPagar() => throw new Exception("Operação não suportada, o pedido já foi pago e enviado.");
    
    public void CancelarPedido() => throw new Exception("Operação não suportada, o pedido já foi pago e enviado.");
    
    public void DespacharPedido() => throw new Exception("Operação não suportada, o pedido já foi pago e enviado.");
}