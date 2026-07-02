namespace PadroesDeProjeto.Estruturais.Aula_6___Decorator;

public class PizzaQueijo : Pizza
{
    public PizzaQueijo()
    {
        Descricao = "Pizza de Queijo";
    }

    public override string GetDescricao() => Descricao;

    public override decimal GetPreco() => 22;
}