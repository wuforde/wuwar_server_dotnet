using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Wu.WuDeck;

public class WuDeck
{
    public readonly string[] Suites = ["Hearts","Spades","Diamonds","Clubs"];
    public enum SuiteNames {Hearts = 0,Spades,Diamonds,Clubs}
    public readonly string[] Cards = ["2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"];
    public enum CardNames {Two = 0,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King,Ace};
    public readonly int[] CardValues = [2,3,4,5,6,7,8,9,10,11,12,13,14];
    public enum CardValueInts {Two= 2,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King,Ace};

    public List<Card> Deck = new List<Card>();

    public WuDeck(int numOfDecks = 1)
    {
        this.CreateDeck(numOfDecks);
    }

    public void CreateDeck(int numOfDecks)
    {
        for(int j = 0; j < numOfDecks; j++)
        {
            for(int i = 0; i < this.Suites.Length; i++)
            {
                for(int k = 0; k < this.Cards.Length; k++)
                {
                    this.Deck.Add(new Card(this.Suites[i],this.CardValues[k],this.Cards[k]));
                }
            }
        }
    }

    public List<List<Card>> Deal(int numOfPlayers)
    {
        List<List<Card>>  hands = new List<List<Card>> (numOfPlayers);
        int evenHands = this.Deck.Count / numOfPlayers;

        for(int i = 0; i < evenHands * numOfPlayers; i++)
        {
            if(i==0) //init hands
            {
                for(int k =0; k < numOfPlayers; k++)
                {
                    hands.Add(new List<Card>());
                }
            }

            hands[i % numOfPlayers].Add(new Card(this.Deck[i].Suite,this.Deck[i].Value, this.Deck[i].Name));
        }

        return hands;
    }

    
    public List<Card> Shuffle(int numberOfShuffles = 1)
    {
        int cnt = this.Deck.Count -1;
        List<Card> retDeck = new List<Card>();

        for(int i = 0; i < numberOfShuffles; i++)
        {
            while(cnt >= 0)
            {
                int index= new Random().Next(cnt);
                retDeck.Add(this.Deck[index]);
                this.Deck.RemoveAt(index);
                cnt--;
            }
        }

        this.Deck = new List<Card>(retDeck);
        return this.Deck;
    }

}

public class Card
{
    public string Suite {get;set;}
    public int Value {get;set;}

    public string Name {get;set;}

    public Card(string suite = "", int value = 0, string name = "")
    {
        this.Suite = suite;
        this.Value = value;
        this.Name = name;
    }


}