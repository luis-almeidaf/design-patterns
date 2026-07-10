namespace PadroesDeProjeto.Comportamentais.Aula_11___Chain_of_Responsibility;

public class Pontos20Reais : ICalculadorDePontos
{
    private ICalculadorDePontos Proximo { get; set; } = null!;

    public int CalcularPontos(PedidoCoR pedido)
    {
        if (pedido.GetValor() >= 20)
            return (int)(pedido.GetValor() / 10);

        return Proximo.CalcularPontos(pedido);
    }

    public void SetProximo(ICalculadorDePontos proximo) => Proximo = proximo;
}