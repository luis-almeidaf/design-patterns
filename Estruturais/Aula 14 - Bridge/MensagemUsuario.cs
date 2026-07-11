namespace PadroesDeProjeto.Estruturais.Aula_14___Bridge;

public class MensagemUsuario(ICanalDeEnvio canal) : Mensagem(canal)
{
    public override void Enviar()
    {
        Console.WriteLine("Mensagem enviada pelo USUÁRIO");
        Canal.EnviarMensagem(Assunto, Message);
    }
}