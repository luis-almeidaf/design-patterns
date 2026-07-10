namespace PadroesDeProjeto.Comportamentais.Aula_12___Iterator;

public class ImpressoraDeAgregado
{
    public static void Iterar(IAgregado agregado)
    {
        var iterator = agregado.CreateIterator();
        while (iterator.HasNext())
            Console.WriteLine(iterator.Next());
    }
}