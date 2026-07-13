namespace PadroesDeProjeto.Estruturais.Aula_16___Composite;

public class GerenciadorDeArquivos(Component raiz)
{
    private Component Raiz { get; set; } = raiz;

    public void ExibirTodos() => Raiz.Exibir();
}