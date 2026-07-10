namespace PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;

public class ArCondicionado(string identificacao, bool estado, int temperatura)
{
    private readonly string _identificacao = identificacao;
    private bool _estado = estado;
    private int _temperatura = temperatura;

    public void Ligar() => _estado = true;

    public void Desligar() => _estado = false;

    public void SetTemperatura(int temp) => _temperatura = temp;

    public string GetIdentificacao() => _identificacao;

    public bool GetEstado() => _estado;

    public int GetTemperatura() => _temperatura;

    public void ImprimeObjeto()
    {
        var identificacao = "O objeto: " + _identificacao + " está - ";
        identificacao += _estado ? "ligado" : "desligado";
        identificacao += _estado ? " a " + _temperatura + " graus celsius." : ".";
        Console.WriteLine(identificacao);
    }
}