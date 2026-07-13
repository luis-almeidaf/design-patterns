namespace PadroesDeProjeto.Estruturais.Aula_16___Composite;

public abstract class Component
{
    public virtual void Adicionar(Component component) => throw new NotImplementedException();

    public virtual void Remover(Component component) => throw new NotImplementedException();

    public virtual Component RecuperarFilho(int indice) => throw new NotImplementedException();

    public virtual void Exibir(int nivel = 0) => throw new NotImplementedException();

    public virtual string GetNome() => throw new NotImplementedException();

    public virtual string GetCaminho() => throw new NotImplementedException();
}