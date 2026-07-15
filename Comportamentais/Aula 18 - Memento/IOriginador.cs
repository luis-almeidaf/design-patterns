namespace PadroesDeProjeto.Comportamentais.Aula_18___Memento;

public interface IOriginador
{
    public IMemento Salvar();
    public void Imprimir();
}