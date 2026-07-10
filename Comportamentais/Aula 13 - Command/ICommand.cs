namespace PadroesDeProjeto.Comportamentais.Aula_13___Command;

public interface ICommand
{
    public void Executar();
    public void Desfazer();
}