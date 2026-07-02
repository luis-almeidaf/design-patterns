namespace PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;

public class PedidoFacade(Consumidor Consumidor)
{
    private List<Produto> Produtos = [];
    private decimal ValorTotal;

    public Consumidor GetConsumidor() => Consumidor;
    
    public List<Produto> GetProdutos() => Produtos;
    
    public decimal GetValorTotal() => ValorTotal;

    public void AddProduto(Produto produto)
    {
        Produtos.Add(produto);
        ValorTotal += produto.GetValor();
    }
}