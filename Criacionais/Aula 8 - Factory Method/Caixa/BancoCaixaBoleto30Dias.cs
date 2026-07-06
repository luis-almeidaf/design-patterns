namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.Caixa;

public class BancoCaixaBoleto30Dias : Boleto
{
    public BancoCaixaBoleto30Dias(decimal valor) : base(valor)
    {
        Juros = 0.05m;
        Desconto = 0.05m;
        Multa = 0.1m;
    }
}