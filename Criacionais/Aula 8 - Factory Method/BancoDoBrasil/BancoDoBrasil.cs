namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.BancoDoBrasil;

public class BancoDoBrasil : Banco
{
    protected override Boleto CriarBoleto(int vencimentoBoleto, decimal valor)
    {
        switch (vencimentoBoleto)
        {
            case 10:
                return new BancoDoBrasilBoleto10Dias(valor);
            case 30:
                return new BancoDoBrasilBoleto30Dias(valor);
            case 60:
                return new BancoDoBrasilBoleto60Dias(valor);
            default:
                throw new Exception("Vencimento indisponível");
        } 
    }
}