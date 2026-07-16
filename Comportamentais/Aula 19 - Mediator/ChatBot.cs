namespace PadroesDeProjeto.Comportamentais.Aula_19___Mediator;

public class ChatBot : UsuarioChat
{
    private UsuarioChat _ultimoUsuario;

    public ChatBot() : base("CHATBOT")
    {
        _ultimoUsuario = this;
    }

    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"## {GetNome()} enviou: {mensagem}");
        Console.WriteLine("--------\n");
        Mediator!.EnviarMensagem(mensagem, this);
    }

    public override void Receber(string mensagem) => Console.WriteLine($"{GetNome()} recebeu: {mensagem}");

    public bool ValidarMensagem(UsuarioChat usuario)
    {
        if (_ultimoUsuario == usuario)
        {
            Enviar($"Uma mensagem de {usuario.GetNome()} foi negado");
            return false;
        }

        _ultimoUsuario = usuario;
        return true;
    }
}