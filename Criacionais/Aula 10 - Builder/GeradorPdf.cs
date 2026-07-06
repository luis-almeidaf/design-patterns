namespace PadroesDeProjeto.Criacionais.Aula_10___Builder;

public class GeradorPdf
{
    public string PageOrientation { get; set; } = "portrait";
    public string Unit { get; set; } = "mm";
    public int PageSizeX { get; set; } = 210;
    public int PageSizeY { get; set; } = 297;
    public int MarginTop { get; set; } = 30;
    public int MarginRight { get; set; } = 20;
    public int MarginBottom { get; set; } = 30;
    public int MarginLeft { get; set; } = 20;
    public bool HasHeader { get; set; } = false;
    public int HeaderHeight { get; set; } = 0;
    public bool HasFooter { get; set; } = false;
    public int FooterHeight { get; set; } = 0;
    public string PageColor { get; set; } = "#ffffff";
    public string Encode { get; set; } = "UTF-8";

    public override string ToString() => $"""
                                          PageOrientation : {PageOrientation}
                                          Unit            : {Unit}
                                          PageSizeX       : {PageSizeX}
                                          PageSizeY       : {PageSizeY}
                                          MarginTop       : {MarginTop}
                                          MarginRight     : {MarginRight}
                                          MarginBottom    : {MarginBottom}
                                          MarginLeft      : {MarginLeft}
                                          HasHeader       : {HasHeader}
                                          HeaderHeight    : {HeaderHeight}
                                          HasFooter       : {HasFooter}
                                          FooterHeight    : {FooterHeight}
                                          PageColor       : {PageColor}
                                          Encode          : {Encode}
                                          """;
}