namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.BancoDoBrasil;

public class BancoDoBrasilBoleto10Dias : Boleto 
{
    public BancoDoBrasilBoleto10Dias(decimal valor) : base(valor)
    {
        Juros = 0.03m;
        Desconto = 0.05m;
        Multa = 0.02m;
    }
}