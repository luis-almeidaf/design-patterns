namespace PadroesDeProjeto.Comportamentais.Aula_12___Iterator;

public class Lista(int tamanhoMaximo) : IAgregado
{
    private readonly List<object> _lista = [];

    public IIterator CreateIterator() => new ListaIterator(this);

    public bool AddItem(object item)
    {
        if (_lista.Count < tamanhoMaximo)
        {
            _lista.Add(item);
            return true;
        }

        return false;
    }

    public object GetItem(int indice) => _lista[indice];

    public int GetTamanho() => tamanhoMaximo;
}