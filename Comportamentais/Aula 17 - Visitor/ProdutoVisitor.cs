namespace PadroesDeProjeto.Comportamentais.Aula_17___Visitor;

public class ProdutoVisitor(string nome, decimal preco, decimal margemLucro) : IElemento
{
    public string Nome { get; } = nome;

    public decimal Preco { get; } = preco;

    public decimal MargemLucro { get; } = margemLucro;

    public decimal Aceitar(IVisitor visitor) => visitor.VisitProduto(this);
}