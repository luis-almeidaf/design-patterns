namespace PadroesDeProjeto.Estruturais.Aula_6___Decorator;

public class MassaIntegral(Pizza pizza) : AcrescimoDecorator(pizza) 
{
    public override string GetDescricao() => pizza.GetDescricao() + " + massa integral";

    public override decimal GetPreco() => pizza.GetPreco() + 5m;
}