namespace PadroesDeProjeto.Comportamentais.Aula_11___Chain_of_Responsibility;

public class CalculadoraDePontos
{
    public int CalcularPontosDoPedido(PedidoCoR pedido, int dia)
    {
        var pontos70 = new Pontos70Reais();
        var pontos40 = new Pontos40Reais();
        var pontos20 = new Pontos20Reais();
        var nenhumPonto = new NenhumPonto();

        pontos70.SetProximo(pontos40);
        pontos40.SetProximo(pontos20);
        pontos20.SetProximo(nenhumPonto);

        if (dia >= 16 && dia <= 31)
            return pontos70.CalcularPontos(pedido) * 2;

        return pontos70.CalcularPontos(pedido);
    }
}