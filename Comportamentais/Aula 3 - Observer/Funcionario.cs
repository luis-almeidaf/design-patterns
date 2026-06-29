namespace PadroesDeProjeto.Comportamentais.Aula_3___Observer;

public class Funcionario : IObserver
{
    private readonly string _nome;
    private readonly string _email;
    private readonly ISubject _subject;
    
    public Funcionario(string nome, string email, ISubject subject)
    {
        _nome = nome;
        _email = email;
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Update(string mensagem) => Email.EnviarEmail(this, mensagem);

    public string GetNome() => _nome;

    public string GetEmail() => _email;
}