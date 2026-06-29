namespace PadroesDeProjeto.Comportamentais.Aula_3___Observer;

public class Newsletter : ISubject
{
    private  readonly List<IObserver> _observers = [];
    private readonly List<string> _mensagens = [];

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);
    
    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_mensagens[^1]);
        }
    }

    public void AddMensagem(string mensagem)
    {
        _mensagens.Add(mensagem);
        NotifyObservers();
    }
}