using PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;

namespace PadroesDeProjeto.Comportamentais.Aula_13___Command;

public class LigarLampada(Lampada lampada) : ICommand
{
    private readonly Lampada _lampada = lampada;

    public void Executar()
    {
        _lampada.Ligar();
        _lampada.ImprimeObjeto();
    }

    public void Desfazer()
    {
        _lampada.Desligar();
        _lampada.ImprimeObjeto();
    }
}