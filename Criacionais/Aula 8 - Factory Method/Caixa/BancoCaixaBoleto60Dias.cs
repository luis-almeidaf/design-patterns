namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.Caixa;

public class BancoCaixaBoleto60Dias : Boleto
{
    public BancoCaixaBoleto60Dias(decimal valor) : base(valor)
    {
        Juros = 0.10m;
        Desconto = 0.0m;
        Multa = 0.2m;
    }
}