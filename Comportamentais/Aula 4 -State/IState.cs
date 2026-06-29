namespace PadroesDeProjeto.Comportamentais.Aula_4__State;

public interface IState
{
    public void SucessoAoPagar();
    public void CancelarPedido();
    public void DespacharPedido();
}