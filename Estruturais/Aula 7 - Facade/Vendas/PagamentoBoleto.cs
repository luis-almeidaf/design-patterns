namespace PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;

public class PagamentoBoleto(PedidoFacade pedido) : Pagamento(pedido)
{
    public override bool RealizarPagamento() => pedido.GetValorTotal() > 0;
}