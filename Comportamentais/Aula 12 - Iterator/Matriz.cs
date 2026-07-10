namespace PadroesDeProjeto.Comportamentais.Aula_12___Iterator;

public class Matriz(int quantidadeLinhas, int quantidadeColunas) : IAgregado
{
    private int _colunaAtual;
    private int _linhaAtual;
    private object[,] _matriz = new object[quantidadeLinhas, quantidadeColunas];
    private int _quantidadeColunas = quantidadeColunas;
    private int _quantidadeLinhas = quantidadeLinhas;


    public bool AddItem(object item)
    {
        if (_linhaAtual == _quantidadeLinhas - 1 && _colunaAtual == _quantidadeColunas)
            return false;

        if (_colunaAtual == _quantidadeColunas)
        {
            _linhaAtual += 1;
            _colunaAtual = 0;
        }

        _matriz[_linhaAtual, _colunaAtual] = item;
        _colunaAtual += 1;
        return true;
    }

    public object GetItem(int linha, int coluna) => _matriz[linha, coluna];

    public int GetQuantidadeLinhas() => _quantidadeLinhas;

    public int GetQuantidadeColunas() => _quantidadeColunas;

    public IIterator CreateIterator() => new MatrizIterator(this);
}