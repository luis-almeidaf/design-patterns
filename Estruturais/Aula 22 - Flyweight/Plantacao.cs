namespace PadroesDeProjeto.Estruturais.Aula_22___Flyweight;

public class Plantacao
{
    private readonly List<Arvore> _arvores = [];
    private readonly EspecieFabrica _especieFabrica = new();

    public void AdicionarArvore(int x, int y, string nome, string cor, float alturaMaxima)
    {
        var especie = _especieFabrica.GetEspecie(nome, cor, alturaMaxima);
        var arvore = new Arvore(x, y, especie);
        _arvores.Add(arvore);
    }

    public List<Arvore> RetornaArvores() => _arvores;

    public List<EspecieFlyweight> RetornaEspecies() => _especieFabrica.RetornaEspecies();
}