namespace PadroesDeProjeto.Comportamentais.Aula_11___Chain_of_Responsibility;

public interface ICalculadorDePontos
{
    public int CalcularPontos(PedidoCoR pedido);

    public void SetProximo(ICalculadorDePontos proximo);
}