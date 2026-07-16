namespace PadroesDeProjeto.Comportamentais.Aula_19___Mediator;

public abstract class UsuarioChat(string nome)
{
    protected ISalaDeChatMediator? Mediator = null;
    protected readonly string Nome = nome;


    public void SetMediator(ISalaDeChatMediator mediator)
    {
        if (mediator is not null)
            mediator.RemoverUsuario(this);

        Mediator = mediator;
        Mediator!.AdicionarUsuario(this);
    }

    public string GetNome() => Nome;

    public abstract void Enviar(string mensagem);
    public abstract void Receber(string mensagem);
}