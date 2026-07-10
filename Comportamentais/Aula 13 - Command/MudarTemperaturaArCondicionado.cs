using PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;

namespace PadroesDeProjeto.Comportamentais.Aula_13___Command;

public class MudarTemperaturaArCondicionado(ArCondicionado arCondicionado) : ICommand
{
    private ArCondicionado _arCondicionado = arCondicionado;
    private int _temperatura = arCondicionado.GetTemperatura();
    private int _temperaturaAnterior = arCondicionado.GetTemperatura();

    public void SetTemperatura(int temperatura)
    {
        _temperaturaAnterior = _temperatura;
        _temperatura = temperatura;
    }

    public void Executar()
    {
        _arCondicionado.SetTemperatura(_temperatura);
        _arCondicionado.ImprimeObjeto();
    }

    public void Desfazer()
    {
        _arCondicionado.SetTemperatura(_temperaturaAnterior);
        _arCondicionado.ImprimeObjeto();
    }
}