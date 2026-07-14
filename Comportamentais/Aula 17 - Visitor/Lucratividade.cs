namespace PadroesDeProjeto.Comportamentais.Aula_17___Visitor;

public class Lucratividade : IVisitor
{
    public decimal VisitSupermercado(SuperMercado supermercado)
    {
        decimal lucratividade = 0;
        var departamentos = supermercado.Departamentos;

        foreach (var departamento in departamentos)
        {
            var produtos = departamento.Produtos;

            foreach (var produto in produtos)
                lucratividade += CalcularLucratividadeProduto(produto);
        }

        return lucratividade;
    }

    public decimal VisitDepartamento(Departamento departamento)
    {
        decimal lucratividade = 0;
        var produtos = departamento.Produtos;

        foreach (var produto in produtos)
            lucratividade += CalcularLucratividadeProduto(produto);

        return lucratividade;
    }

    public decimal VisitProduto(ProdutoVisitor produto) => CalcularLucratividadeProduto(produto);

    private decimal CalcularLucratividadeProduto(ProdutoVisitor produto) => produto.Preco * produto.MargemLucro / 100;
}