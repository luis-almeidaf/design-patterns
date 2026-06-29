namespace PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;

public abstract class Pagamento(float valor, Gateway gateway)
{
    protected float GetValor() => valor;

    protected virtual float CalcularTaxa() => 0;
    
    protected abstract float CalcularDesconto();

    //Esse é o template method em, um método que vai ter sempre o mesmo esqueleto, onde as lógicas ficam definidas nas subclasses
    public bool RealizarCobranca()
    {
        Console.WriteLine($"{valor} + {CalcularTaxa()} - {CalcularDesconto()}");
        var valorTotal = valor + CalcularTaxa() - CalcularDesconto();

        return gateway.Cobrar(valorTotal);
    }
}