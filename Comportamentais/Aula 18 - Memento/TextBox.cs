namespace PadroesDeProjeto.Comportamentais.Aula_18___Memento;

public class TextBox(int x, int y) : IOriginador
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public string Text { get; set; } = "";
    public string FontFamily { get; set; } = "Arial";
    public int FontSize { get; set; } = 14;
    public string TextAlign { get; set; } = "left";
    public string FontWeight { get; set; } = "normal";

    public IMemento Salvar() => new TextBoxMemento(this, X, Y, Text, FontFamily, FontSize, TextAlign, FontWeight);

    public void Imprimir()
    {
        Console.WriteLine(
            $"x: {X}, y: {Y},  text: {Text}, fontFamily: {FontFamily}, fontSize: {FontSize},  textAlign: {TextAlign}, fontWeight: {FontWeight}");
    }
}