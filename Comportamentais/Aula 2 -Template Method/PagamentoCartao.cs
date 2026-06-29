namespace PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;

public class PagamentoCartao(float valor, Gateway gateway) : Pagamento(valor, gateway)
{
    protected override float CalcularTaxa() => 4;
    protected override float CalcularDesconto() => GetValor() * 0.05f;
}