namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method;

public abstract class Banco
{
    public Boleto GerarBoleto(int vencimentoBoleto, decimal valor)
    {
        var boleto = CriarBoleto(vencimentoBoleto, valor);
        Console.WriteLine(vencimentoBoleto);

        Console.WriteLine("Boleto gerado com sucesso no valor de R$: " + valor);
        Console.WriteLine("Valor Juros: R$" + boleto.CalcularJuros());
        Console.WriteLine("Valor Desconto: R$" + boleto.CalcularDesconto());
        Console.WriteLine("Valor Multa: R$" + boleto.CalcularMulta());
        
        return boleto;
    }
    
    protected abstract Boleto CriarBoleto(int vencimentoBoleto, decimal valor);
}