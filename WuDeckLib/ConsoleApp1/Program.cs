using WuDeckLib;
internal class Program
{
    private static void Main(string[] args)
    {
        WuDeck wuDeck = new WuDeck();
        wuDeck.Cut(8);
        Console.WriteLine("Hello, World!");
    }
}