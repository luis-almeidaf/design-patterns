namespace PadroesDeProjeto.Criacionais.Aula_9___Abstract_Factory;

public interface ICalculosFactory
{
    public IJuros CriarJuros();
    public IDesconto CriarDesconto();
    public IMulta CriarMulta();
}