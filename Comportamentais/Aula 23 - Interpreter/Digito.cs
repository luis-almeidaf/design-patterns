namespace PadroesDeProjeto.Comportamentais.Aula_23___Interpreter;

public class Digito(char digito) : IExpressao
{
    private bool ValidarDigito()
    {
        char[] digitos = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        return digitos.Contains(digito);
    }

    public int Interpretar(Dictionary<char, int> contexto)
    {
        if (ValidarDigito()) return digito - '0';


        throw new Exception("DIGITO INVALIDO");
    }
}