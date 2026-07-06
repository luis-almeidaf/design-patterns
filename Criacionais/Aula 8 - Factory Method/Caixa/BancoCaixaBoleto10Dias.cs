namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.Caixa;

public class BancoCaixaBoleto10Dias : Boleto
{
    public BancoCaixaBoleto10Dias(decimal valor) : base(valor)
    {
        Juros = 0.02m;
        Desconto = 0.1m;
        Multa = 0.05m;
    }
}