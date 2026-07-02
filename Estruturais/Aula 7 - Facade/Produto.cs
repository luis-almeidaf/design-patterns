namespace PadroesDeProjeto.Estruturais.Aula_7___Facade;

public class Produto(string nome, string descricao, decimal valor)
{
    private string Nome { get; set; } = nome;
    private string Descricao { get; set; } = descricao;
    private decimal Valor { get; set; } = valor;
    
    public string GetNome() => Nome;
    public string GetDescricao() => Descricao;
    public decimal GetValor() => Valor;
}