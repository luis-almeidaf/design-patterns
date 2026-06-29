namespace PadroesDeProjeto.Comportamentais.Aula_1__Strategy;

public class PedidoEletronicos : Pedido
{
    private string _nomeSetor = "Eletrônicos";

    public string GetNomeSetor() => _nomeSetor;
    public void SetNomeSetor(string nomeSetor) => _nomeSetor = nomeSetor;
}