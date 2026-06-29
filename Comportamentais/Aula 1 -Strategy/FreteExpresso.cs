namespace PadroesDeProjeto.Comportamentais.Aula_1__Strategy;

public class FreteExpresso : IFrete
{
    public float Calcular(float valorPedido) => valorPedido * 0.1f; //o frete custa 10% do valor do pedido.
}