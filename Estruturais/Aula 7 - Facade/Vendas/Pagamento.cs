namespace PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;

public abstract class Pagamento(PedidoFacade pedido)
{
    public abstract bool RealizarPagamento();
}