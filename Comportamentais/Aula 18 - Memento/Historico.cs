namespace PadroesDeProjeto.Comportamentais.Aula_18___Memento;

public class Historico
{
    private readonly List<IMemento> _historico = [];

    public void CriarCheckPoint(IOriginador originador) => _historico.Add(originador.Salvar());

    public void Desfazer()
    {
        if (_historico.Count <= 1) return;

        _historico.RemoveAt(_historico.Count - 1);
        _historico[^1].Restaurar();
    }

    public void Imprimir(IOriginador originador) => originador.Imprimir();
}