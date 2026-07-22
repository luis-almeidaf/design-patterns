namespace PadroesDeProjeto.Comportamentais.Aula_23___Interpreter;

public class Variavel(char variavel) : IExpressao
{
    private bool ValidarVariavel()
    {
        char[] alfabeto =
        [
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        ];
        return alfabeto.Contains(variavel);
    }

    public int Interpretar(Dictionary<char, int> contexto)
    {
        if (ValidarVariavel())
            return contexto[variavel];

        throw new Exception("A variável precisa ser uma letra de a-z e estar definida no contexto!");
    }
}