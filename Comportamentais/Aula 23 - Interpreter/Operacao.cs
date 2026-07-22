namespace PadroesDeProjeto.Comportamentais.Aula_23___Interpreter;

public abstract class Operacao(IExpressao esquerda, IExpressao direita) : IExpressao
{
    protected IExpressao Esquerda { get; } = esquerda;
    protected IExpressao Direita { get; } = direita;

    public abstract int Interpretar(Dictionary<char, int> contexto);
}