namespace PadroesDeProjeto.Estruturais.Aula_6___Decorator;

public class PizzaCalabresa : Pizza
{
    public PizzaCalabresa()
    {
        Descricao = "Pizza de Calabresa";
    }

    public override string GetDescricao() => Descricao;

    public override decimal GetPreco() => 25;
}