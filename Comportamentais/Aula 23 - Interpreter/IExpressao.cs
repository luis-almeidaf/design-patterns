namespace PadroesDeProjeto.Comportamentais.Aula_23___Interpreter;

public interface IExpressao
{
    public int Interpretar(Dictionary<char, int> contexto);
}