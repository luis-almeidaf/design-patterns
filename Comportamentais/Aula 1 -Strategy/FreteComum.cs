namespace PadroesDeProjeto.Comportamentais.Aula_1__Strategy;

public class FreteComum : IFrete
{
    public float Calcular(float valorPedido) => valorPedido * 0.05f; //o frete custa 5% do valor do pedido.
}