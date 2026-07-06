namespace PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory.Caixa;

public class CaixaCalculosFactory : ICalculosFactory
{
    public IJuros CriarJuros() => new  CaixaJuros();

    public IDesconto CriarDesconto() => new CaixaDesconto();

    public IMulta CriarMulta() => new  CaixaMulta();
}