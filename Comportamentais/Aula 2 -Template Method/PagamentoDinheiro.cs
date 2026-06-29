namespace PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;

public class PagamentoDinheiro(float valor, Gateway gateway) : Pagamento(valor, gateway)
{
    protected override float CalcularDesconto() => GetValor() * 0.1f;
}