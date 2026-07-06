namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.BancoDoBrasil;

public class BancoDoBrasilBoleto30Dias : Boleto
{
    public BancoDoBrasilBoleto30Dias(decimal valor) : base(valor)
    {
        Juros = 0.05m;
        Desconto = 0.02m;
        Multa = 0.05m;
    }
}