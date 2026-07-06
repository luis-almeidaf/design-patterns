namespace PadroesDeProjeto.Criacionais.Aula_8___Factory_Method.Caixa;

public class BancoCaixa : Banco
{
    protected override Boleto CriarBoleto(int vencimentoBoleto, decimal valor)
    {
        switch (vencimentoBoleto)
        {
            case 10:
                return new BancoCaixaBoleto10Dias(valor);
            case 30:
                return new BancoCaixaBoleto30Dias(valor);
            case 60:
                return new BancoCaixaBoleto60Dias(valor);
            default:
                throw new Exception("Vencimento indisponível");
        } 
    }
}