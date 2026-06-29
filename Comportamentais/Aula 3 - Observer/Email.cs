namespace PadroesDeProjeto.Comportamentais.Aula_3___Observer;

public static class Email 
{
    public static void EnviarEmail(IObserver observer, string mensagem)
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Email enviado para: " + observer.GetNome() + " - " + observer.GetEmail() + "\n");
        Console.WriteLine("Mensagem: " + mensagem + "\n\n");
    }
}