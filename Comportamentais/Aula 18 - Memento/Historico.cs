namespace PadroesDeProjeto.Comportamentais.Aula_18___Memento;

public class Historico
{
    private readonly List<IMemento> _historico = [];

    public void CriarCheckPoint(IOriginador originador) => _historico.Add(originador.Salvar());

    public void Desfazer()
    {
        if (_historico.Count == 0)
            return;

        var memento = _historico[^1];
        _historico.RemoveAt(_historico.Count - 1);
        memento.Restaurar();
    }

    public void Imprimir(IOriginador originador) => originador.Imprimir();
}