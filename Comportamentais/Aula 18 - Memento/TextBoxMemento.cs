namespace PadroesDeProjeto.Comportamentais.Aula_18___Memento;

public class TextBoxMemento(
    TextBox textBox,
    int x,
    int y,
    string text,
    string fontFamily,
    int fontSize,
    string textAlign,
    string fontWeight)
    : IMemento
{
    private int X { get; } = x;
    private int Y { get; } = y;
    private string Text { get; } = text;
    private string FontFamily { get; } = fontFamily;
    private int FontSize { get; } = fontSize;
    private string TextAlign { get; } = textAlign;
    private string FontWeight { get; } = fontWeight;

    public void Restaurar()
    {
        textBox.X = X;
        textBox.Y = Y;
        textBox.Text = Text;
        textBox.FontFamily = FontFamily;
        textBox.FontSize = FontSize;
        textBox.TextAlign = TextAlign;
        textBox.FontWeight = FontWeight;
    }
}