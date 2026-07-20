namespace PadroesDeProjeto.Estruturais.Aula_22___Flyweight;

public class EspecieFabrica
{
    private readonly List<EspecieFlyweight> _especies = [];

    public EspecieFlyweight GetEspecie(string nome, string cor, float alturaMaxima)
    {
        foreach (var e in _especies)
            if (e.Nome == nome &&
                e.Cor == cor &&
                e.AlturaMaxima == alturaMaxima)
                return e;

        var novaEspecie = new EspecieFlyweight(nome, cor, alturaMaxima);
        _especies.Add(novaEspecie);
        return novaEspecie;
    }

    public List<EspecieFlyweight> RetornaEspecies() => _especies;
}