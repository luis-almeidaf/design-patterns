namespace PadroesDeProjeto.Comportamentais.Aula_17___Visitor;

public class Departamento(string nome) : IElemento
{
    public string Nome { get; } = nome;

    private List<ProdutoVisitor> _produtos = [];

    public void AddProduto(ProdutoVisitor produto) => _produtos.Add(produto);

    public List<ProdutoVisitor> Produtos => _produtos;

    public decimal Aceitar(IVisitor visitor) => visitor.VisitDepartamento(this);
}