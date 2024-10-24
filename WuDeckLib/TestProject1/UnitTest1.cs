using WuDeckLib;

namespace TestProject1;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void TestNew()
    {
        WuDeck deck = new WuDeck();
        List<Card> cpu = new List<Card>();
        List<Card> player = new List<Card>();
        List<List<Card>> hands = new List<List<Card>>();

        Assert.IsTrue(deck.Deck.Count == 52);
    } 

        [TestMethod]
    public void TestShuffleAndDeal()
    {
        WuDeck deck = new WuDeck();
        List<Card> cpu = new List<Card>();
        List<Card> player = new List<Card>();
        List<List<Card>> hands = new List<List<Card>>();

        deck.Shuffle();
        deck.Cut();
        deck.Shuffle();
        deck.Cut();
        hands = deck.Deal(2);
        cpu = hands[0];
        player = hands[1];

        Assert.AreNotEqual(cpu,player);
    } 
}