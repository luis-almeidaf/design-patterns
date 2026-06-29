namespace PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;

public class Gateway
{
    public bool Cobrar(float valorTotal)
    {
        var respostas = new List<bool> {true, false};
        var random = new Random();
        Console.WriteLine(valorTotal);
        var status = random.Next(0, 1);
        return respostas[status];
    }
}