using PadroesDeProjeto.Comportamentais.Aula_1__Strategy;

namespace PadroesDeProjeto.Estruturais.Aula_7___Facade.Vendas;

public class EmailPedido(PedidoFacade pedido)
{
    public void EnviarEmail(string mensagem)
    {
        Console.WriteLine("Email enviado para: " + pedido.GetConsumidor().GetEmail());
        Console.WriteLine("Mensagem: " + mensagem);
    }
}