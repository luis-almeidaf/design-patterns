namespace PadroesDeProjeto.Estruturais.Aula_14___Bridge;

public class MensagemAdmin(ICanalDeEnvio canal) : Mensagem(canal)
{
    public override void Enviar()
    {
        Console.WriteLine("Mensagem enviada pelo ADMINISTRADOR");
        Canal.EnviarMensagem(Assunto, Message);
    }
}