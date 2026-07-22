namespace PadroesDeProjeto.Comportamentais.Aula_23___Interpreter;

public class Numero(Digito esquerda, Numero? direita = null) : IExpressao
{
    public int Interpretar(Dictionary<char, int> contexto)
    {
        if (direita is null)
            return esquerda.Interpretar(contexto);

        return int.Parse(
            $"{esquerda.Interpretar(contexto)}{direita.Interpretar(contexto)}"
        );
    }
}