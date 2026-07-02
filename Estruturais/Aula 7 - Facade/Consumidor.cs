namespace PadroesDeProjeto.Estruturais.Aula_7___Facade;

public class Consumidor(string nome, string cpf, string email)
{
    private string Nome { get; set; } = nome;
    private string Cpf { get; set; } = cpf;
    private string Email { get; set; } = email;

    public string GetNome() => Nome;
    public string GetCpf() => Cpf;
    public string GetEmail() => Email;
}