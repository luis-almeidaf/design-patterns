namespace PadroesDeProjeto.Criacionais.Aula_10___Builder;

public class GeradorPdfDirector(IBuilderGeradorPdf builderGeradorPdf)
{
    private IBuilderGeradorPdf _builderGeradorPdf = builderGeradorPdf;

    public void SetBuilderGeradorPdf(IBuilderGeradorPdf builderGeradorPdf) => _builderGeradorPdf = builderGeradorPdf;

    public void CriarGeradorPdf()
    {
        _builderGeradorPdf.SetPageConfiguration();
        _builderGeradorPdf.SetMargin();
        _builderGeradorPdf.SetHeader();
        _builderGeradorPdf.SetFooter();
    }

    public void CriarGeradorPdfNoHeader()
    {
        _builderGeradorPdf.SetPageConfiguration();
        _builderGeradorPdf.SetMargin();
        _builderGeradorPdf.SetFooter();
    }

    public void CriarGeradorPdfNoHeaderNoHeader()
    {
        _builderGeradorPdf.SetPageConfiguration();
        _builderGeradorPdf.SetMargin();
    }
}