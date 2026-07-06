namespace PadroesDeProjeto.Criacionais.Aula_10___Builder;

public interface IBuilderGeradorPdf
{
    public GeradorPdf GetGeradorPdf();
    public void SetPageConfiguration();
    public void SetMargin();
    public void SetHeader();
    public void SetFooter();
}