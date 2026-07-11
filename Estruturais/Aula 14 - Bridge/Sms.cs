namespace PadroesDeProjeto.Estruturais.Aula_14___Bridge;

public class Sms : ICanalDeEnvio
{
    public void EnviarMensagem(string assunto, string mensagem)
    {
        Console.WriteLine("Mensagem enviada por sms");
        Console.WriteLine("Assunto: " + assunto);
        Console.WriteLine("Mensagem: " + mensagem);
        Console.WriteLine("---------------------");
    }
}