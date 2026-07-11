namespace PadroesDeProjeto.Estruturais.Aula_14___Bridge;

public abstract class Mensagem(ICanalDeEnvio canal)
{
    protected string Assunto = null!;
    protected string Message = null!;
    protected ICanalDeEnvio Canal = canal;

    public void SetAssunto(string assunto) => Assunto = assunto;
    public void SetMensagem(string mensagem) => Message = mensagem;

    public abstract void Enviar();
}