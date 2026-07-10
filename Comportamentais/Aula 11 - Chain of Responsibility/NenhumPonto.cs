namespace PadroesDeProjeto.Comportamentais.Aula_11___Chain_of_Responsibility;

public class NenhumPonto : ICalculadorDePontos
{
    public int CalcularPontos(PedidoCoR pedido) => 0;

    public void SetProximo(ICalculadorDePontos proximo) { }
}