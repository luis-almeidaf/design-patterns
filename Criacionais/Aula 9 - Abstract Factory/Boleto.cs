namespace PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory;

public class Boleto(decimal valor, ICalculosFactory factory)
{
    protected decimal Valor = valor;
    protected IJuros Juros = factory.CriarJuros();
    protected IDesconto Desconto = factory.CriarDesconto();
    protected IMulta Multa = factory.CriarMulta();
    
    public decimal CalcularJuros() => Valor * Juros.GetJuros();

    public decimal CalcularDesconto() => Valor * Desconto.GetDesconto();

    public decimal CalcularMulta() => Valor * Multa.GetMulta();
}