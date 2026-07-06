namespace PadroesDeProjeto.Criacionais.Aula_10___Builder;

public class BuilderA4 : IBuilderGeradorPdf
{
    private readonly GeradorPdf _geradorPdf = new();

    public GeradorPdf GetGeradorPdf() => _geradorPdf;

    public void SetPageConfiguration()
    {
        _geradorPdf.PageOrientation = "Portrait";
        _geradorPdf.Unit = "mm";
        _geradorPdf.PageSizeX = 210;
        _geradorPdf.PageSizeY = 297;
        _geradorPdf.PageColor = "#ffffff";
        _geradorPdf.Encode = "UTF-8'";
    }

    public void SetMargin()
    {
        _geradorPdf.MarginTop = 30;
        _geradorPdf.MarginRight = 20;
        _geradorPdf.MarginBottom = 30;
        _geradorPdf.MarginLeft = 20;
    }

    public void SetHeader()
    {
        _geradorPdf.HasHeader = true;
        _geradorPdf.HeaderHeight = 15;
    }

    public void SetFooter()
    {
        _geradorPdf.HasFooter = true;
        _geradorPdf.FooterHeight = 15;
    }
}