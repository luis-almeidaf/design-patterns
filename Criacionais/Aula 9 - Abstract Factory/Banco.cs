namespace PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory;

public class Banco
{
    public Boleto GerarBoleto(decimal valor, ICalculosFactory factory)
    {
        var boleto = new Boleto(valor, factory);
        
        Console.WriteLine("Boleto gerado com sucesso no valor de R$: " + valor);
        Console.WriteLine("Valor Juros: R$" + boleto.CalcularJuros());
        Console.WriteLine("Valor Desconto: R$" + boleto.CalcularDesconto());
        Console.WriteLine("Valor Multa: R$" + boleto.CalcularMulta());
        
        return boleto;
    }
}