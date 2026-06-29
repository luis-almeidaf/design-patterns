namespace PadroesDeProjeto.Comportamentais.Aula_1__Strategy;

public class Pedido
{
    protected IFrete Frete;
    protected float ValorPedido;
    
    public float GetValorPedido() => ValorPedido;
    
    public void SetValorPedido(float valorPedido) => ValorPedido = valorPedido;
    
    public void SetTipoFrete(IFrete frete) => Frete = frete;

    public float CalcularValorFrete() => Frete.Calcular(ValorPedido);
}