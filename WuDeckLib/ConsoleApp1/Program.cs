using WuDeckLib;
internal class Program
{
    private static void Main(string[] args)
    {
        WuDeck wuDeck = new WuDeck();
        List<Card> cpu = new List<Card>();
        List<Card> player = new List<Card>();
        List<List<Card>> hands = new List<List<Card>>();

        hands = wuDeck.Deal(2);
        cpu = hands[0];
        player = hands[1];


        Console.WriteLine(wuDeck.Deck.Count == 52);
        Console.WriteLine("Hello, World!");
    }
}