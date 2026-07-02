namespace PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;

public class PagamentoCredito(PedidoFacade pedido) : Pagamento(pedido)
{
    public override bool RealizarPagamento() => pedido.GetValorTotal() > 0;
}