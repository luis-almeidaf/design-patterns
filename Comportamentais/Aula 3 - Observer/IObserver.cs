namespace PadroesDeProjeto.Comportamentais.Aula_3___Observer;

public interface IObserver
{
    public void Update(string mensagem);
    public string GetNome();
    public string GetEmail();
}