namespace PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;

public class VendaFacade
{
    private PedidoFacade _pedido;
    private Pagamento  Pagamento;
    private EmailPedido EmailPedido;

    public VendaFacade(Consumidor consumidor)
    {
        _pedido = new PedidoFacade(consumidor);
        EmailPedido = new EmailPedido(_pedido);
    }
    
    public void AddProduto(Produto produto) => _pedido.AddProduto(produto);

    public void PedidoCredito()
    {
        Pagamento = new PagamentoCredito(_pedido);
        EmailPedido.EnviarEmail(Pagamento.RealizarPagamento()
            ? $"Pagamento realizado via cŕedito no valor de R$: {_pedido.GetValorTotal()}" 
            : "Falha no pagamento via cŕedito");
    }
    
    public void PedidoBoleto()
    {
        Pagamento = new PagamentoCredito(_pedido);
        EmailPedido.EnviarEmail(Pagamento.RealizarPagamento()
            ? $"Pagamento realizado via boleto no valor de R$: {_pedido.GetValorTotal()}"
            : "Falha no pagamento do boleto");
    }
}