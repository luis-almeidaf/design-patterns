namespace PadroesDeProjeto.Estruturais.Aula_6___Decorator;

public class BordaRequeijao(Pizza pizza) : AcrescimoDecorator(pizza) 
{
    public override string GetDescricao() => pizza.GetDescricao() + " + borda recheada de requeijão";

    public override decimal GetPreco() => pizza.GetPreco() + 8.5m;
}