namespace PadroesDeProjeto.Criacionais.Aula_10___Builder;

public class BuilderA3 : IBuilderGeradorPdf
{
    private readonly GeradorPdf _geradorPdf = new();

    public GeradorPdf GetGeradorPdf() => _geradorPdf;

    public void SetPageConfiguration()
    {
        _geradorPdf.PageOrientation = "Portrait";
        _geradorPdf.Unit = "mm";
        _geradorPdf.PageSizeX = 297;
        _geradorPdf.PageSizeY = 420;
        _geradorPdf.PageColor = "#ffffff";
        _geradorPdf.Encode = "UTF-8'";
    }

    public void SetMargin()
    {
        _geradorPdf.MarginTop = 60;
        _geradorPdf.MarginRight = 40;
        _geradorPdf.MarginBottom = 60;
        _geradorPdf.MarginLeft = 40;
    }

    public void SetHeader()
    {
        _geradorPdf.HasHeader = false;
        _geradorPdf.HeaderHeight = 0;
    }

    public void SetFooter()
    {
        _geradorPdf.HasFooter = false;
        _geradorPdf.FooterHeight = 0;
    }
}