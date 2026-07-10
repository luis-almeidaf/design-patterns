namespace PadroesDeProjeto.Comportamentais.Aula_12___Iterator;

public class ListaIterator(Lista lista) : IIterator
{
    private int _indice;
    private readonly int _tamanho = lista.GetTamanho();
    private Lista Lista { get; } = lista;

    public bool HasNext() => _indice < _tamanho;

    public object Next()
    {
        var item = Lista.GetItem(_indice);
        _indice++;
        return item;
    }
}