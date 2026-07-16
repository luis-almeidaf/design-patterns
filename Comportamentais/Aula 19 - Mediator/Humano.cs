namespace PadroesDeProjeto.Comportamentais.Aula_19___Mediator;

public class Humano(string nome) : UsuarioChat(nome)
{
    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"## {Mediator!.GetNome()} ##");
        Console.WriteLine(GetNome() + " enviou: " + mensagem);
        Console.WriteLine("--------\n");
        Mediator.EnviarMensagem(mensagem, this);
    }

    public override void Receber(string mensagem) => Console.WriteLine($"{GetNome()} recebeu: {mensagem}");
}