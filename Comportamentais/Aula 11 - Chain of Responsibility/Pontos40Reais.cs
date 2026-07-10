namespace PadroesDeProjeto.Comportamentais.Aula_11___Chain_of_Responsibility;

public class Pontos40Reais : ICalculadorDePontos
{
    private ICalculadorDePontos Proximo { get; set; } = null!;

    public int CalcularPontos(PedidoCoR pedido)
    {
        if (pedido.GetValor() >= 40)
            return (int)(pedido.GetValor() / 7);

        return Proximo.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorDePontos proximo) => Proximo = proximo;
}