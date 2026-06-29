namespace PadroesDeProjeto.Comportamentais.Aula_2__Template_Method;

public class PagamentoCredito(float valor, Gateway gateway) : Pagamento(valor, gateway)
{
    protected override float CalcularTaxa() => GetValor() * 0.05f;

    protected override float CalcularDesconto()
    {
        if (GetValor() > 300)
        {
            return GetValor() * 0.02f;
        }

        return 0;
    }
}