namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method;

public abstract class Boleto(decimal valor)
{
    protected decimal Valor { get; set; } = valor;
    protected decimal Juros { get; set; }
    protected decimal Desconto { get; set; }
    protected decimal Multa { get; set; }
    
    public decimal CalcularJuros() => Valor * Juros;
    
    public decimal CalcularDesconto() => Valor * Desconto;
    
    public decimal CalcularMulta() => Valor * Multa;
}