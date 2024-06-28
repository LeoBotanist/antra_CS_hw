namespace ObjectOrientedProgramming;

public class Color
{
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }
    public byte Alpha { get; set; }

    public Color()
    {
        Random random = new Random();
        byte[] values = new byte[4];
        random.NextBytes(values);
        Red = values[0];
        Green = values[1];
        Blue = values[2];
        Alpha = values[3];
    }
    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }

    public Color(byte red, byte green, byte blue, byte alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public byte Color2Gray()
    {
        return (byte) ((Red + Green + Blue) / 3);
    }
}