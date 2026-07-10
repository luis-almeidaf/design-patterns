namespace PadroesDeProjeto.Comportamentais.Aula_12___Iterator;

public class MatrizIterator(Matriz matriz) : IIterator
{
    private Matriz _matriz = matriz;
    private int _indiceLinha = 0;
    private int _indiceColuna = 0;
    private int _quantidadeLinhas = matriz.GetQuantidadeLinhas();
    private int _quantidadeColunas = matriz.GetQuantidadeColunas();

    public void IncrementarIndice()
    {
        if (_indiceColuna == _quantidadeColunas - 1)
        {
            _indiceLinha += 1;
            _indiceColuna = 0;
        }
        else
        {
            _indiceColuna += 1;
        }
    }

    public bool HasNext() => _indiceLinha < _quantidadeLinhas;

    public object Next()
    {
        var item = matriz.GetItem(_indiceLinha, _indiceColuna);
        IncrementarIndice();
        return item;
    }
}