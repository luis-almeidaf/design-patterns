namespace PadroesDeProjeto.Comportamentais.Aula_1__Strategy;

public class PedidoMoveis : Pedido
{
    private string _nomeSetor = "Móveis";

    public string GetNomeSetor() => _nomeSetor;
    public void SetNomeSetor(string nomeSetor) => _nomeSetor = nomeSetor;
}