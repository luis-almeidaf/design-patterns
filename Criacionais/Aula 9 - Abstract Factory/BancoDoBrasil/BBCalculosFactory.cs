namespace PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory.BancoDoBrasil;

public class BBCalculosFactory : ICalculosFactory
{
    public IJuros CriarJuros() => new BBJuros();

    public IDesconto CriarDesconto() => new BBDesconto();

    public IMulta CriarMulta() => new BBMulta();
}