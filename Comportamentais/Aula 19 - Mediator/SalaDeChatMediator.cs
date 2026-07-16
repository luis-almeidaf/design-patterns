namespace PadroesDeProjeto.Comportamentais.Aula_19___Mediator;

public class SalaDeChatMediator : ISalaDeChatMediator
{
    private readonly List<UsuarioChat> _usuarios;
    private readonly ChatBot _chatBot;
    private readonly string _nome;

    public SalaDeChatMediator(ChatBot chatBot, string nome)
    {
        _usuarios = [];
        _chatBot = chatBot;
        chatBot.SetMediator(this);
        _nome = nome;
    }

    public void EnviarMensagem(string mensagem, UsuarioChat usuario)
    {
        if (!_chatBot.ValidarMensagem(usuario)) return;
        foreach (var u in _usuarios.Where(u => u != usuario))
            u.Receber(mensagem);
        Console.WriteLine("----------------------------------");
    }

    public void AdicionarUsuario(UsuarioChat usuario) => _usuarios.Add(usuario);

    public void RemoverUsuario(UsuarioChat usuario)
    {
        foreach (var u in _usuarios.Where(u => u == usuario).ToList())
            _usuarios.Remove(u);
    }

    public string GetNome() => _nome;
}