namespace PadroesDeProjeto.Comportamentais.Aula_17___Visitor;

public class SuperMercado(string nome) : IElemento
{
    public string Nome { get; } = nome;

    private List<Departamento> _departamentos { get; } = [];

    public void AddDepartamento(Departamento departamento) => _departamentos.Add(departamento);

    public List<Departamento> Departamentos => _departamentos;

    public decimal Aceitar(IVisitor visitor) => visitor.VisitSupermercado(this);
}