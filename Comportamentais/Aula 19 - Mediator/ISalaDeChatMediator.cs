namespace PadroesDeProjeto.Comportamentais.Aula_19___Mediator;

public interface ISalaDeChatMediator
{
    public void EnviarMensagem(string mensagem, UsuarioChat usuario);
    public void AdicionarUsuario(UsuarioChat usuario);
    public void RemoverUsuario(UsuarioChat usuario);
    public string GetNome();
}