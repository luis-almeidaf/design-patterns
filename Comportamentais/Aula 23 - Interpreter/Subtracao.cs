namespace PadroesDeProjeto.Comportamentais.Aula_23___Interpreter;

public class Subtracao(IExpressao esquerda, IExpressao direita) : Operacao(esquerda, direita)
{
    public override int Interpretar(Dictionary<char, int> contexto) =>
        Esquerda.Interpretar(contexto) - Direita.Interpretar(contexto);
}