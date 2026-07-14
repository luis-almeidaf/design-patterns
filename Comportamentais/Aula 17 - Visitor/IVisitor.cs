namespace PadroesDeProjeto.Comportamentais.Aula_17___Visitor;

public interface IVisitor
{
    public decimal VisitSupermercado(SuperMercado supermercado);
    public decimal VisitDepartamento(Departamento departamento);
    public decimal VisitProduto(ProdutoVisitor produto);
}