namespace PadroesDeProjeto.Estruturais.Aula_6___Decorator;

public class PizzaFrango : Pizza
{
    public PizzaFrango()
    {
        Descricao = "Pizza de Frango";
    }

    public override string GetDescricao() => Descricao;

    public override decimal GetPreco() => 23;
}