using WuDeckLib;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        WuDeck deck = new WuDeck();
        deck.Cut(3);
        Assert.IsTrue(deck.Deck.Count == 52);
    }
}