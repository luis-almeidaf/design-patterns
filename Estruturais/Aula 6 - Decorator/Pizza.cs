namespace PadroesDeProjeto.Estruturais.Aula_6___Decorator;

public abstract class Pizza
{
    public string Descricao { get; set; } =  "Descrição não definida";
    public decimal Preco { get; set; }

    public abstract string GetDescricao();
    public abstract decimal GetPreco();
}