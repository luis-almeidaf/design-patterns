namespace PadroesDeProjeto.Comportamentais.Aula_13___Command.Fabricante;

public class Lampada(string identificacao, bool estado)
{
    private readonly string _identificacao = identificacao;
    private bool _estado = estado;

    public void Ligar() => _estado = true;

    public void Desligar() => _estado = false;

    public string GetIdentificacao() => _identificacao;

    public bool GetEstado() => _estado;

    public void ImprimeObjeto()
    {
        var identificacao = "O objeto: " + _identificacao + " está - ";
        identificacao += _estado ? "ligado" : "desligado";
        Console.WriteLine(identificacao);
    }
}