using PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;

namespace PadroesDeProjeto.Comportamentais.Aula_13___Command;

public class DesligarLampada(Lampada lampada) : ICommand
{
    private readonly Lampada _lampada = lampada;

    public void Executar()
    {
        _lampada.Desligar();
        _lampada.ImprimeObjeto();
    }

    public void Desfazer()
    {
        _lampada.Ligar();
        _lampada.ImprimeObjeto();
    }
}