using PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;

namespace PadroesDeProjeto.Comportamentais.Aula_13___Command;

public class LigarArCondicionado(ArCondicionado arCondicionado) : ICommand
{
    private readonly ArCondicionado _arCondicionado = arCondicionado;

    public void Executar()
    {
        _arCondicionado.Ligar();
        _arCondicionado.ImprimeObjeto();
    }

    public void Desfazer()
    {
        _arCondicionado.Desligar();
        _arCondicionado.ImprimeObjeto();
    }
}