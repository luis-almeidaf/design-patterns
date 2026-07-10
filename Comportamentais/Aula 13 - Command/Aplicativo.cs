namespace PadroesDeProjeto.Comportamentais.Aula_13___Command;

public class Aplicativo
{
    private readonly List<ICommand> _comandos = [];

    public int SetComando(ICommand command)
    {
        _comandos.Add(command);
        return _comandos.Count - 1;
    }

    public void AoPressionarBotao(int idBotao) => _comandos[idBotao].Executar();

    public void DuploCliqueBotao(int idBotao) => _comandos[idBotao].Desfazer();

    public ICommand GetComando(int id) => _comandos[id];
}