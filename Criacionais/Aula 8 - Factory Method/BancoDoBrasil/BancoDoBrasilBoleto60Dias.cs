namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.BancoDoBrasil;

public class BancoDoBrasilBoleto60Dias : Boleto
{
    public BancoDoBrasilBoleto60Dias(decimal valor) : base(valor)
    {
        Juros = 0.10m;
        Desconto = 0;
        Multa = 0.15m;
    }
}