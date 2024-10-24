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

        int[] arr = new int[9] { 1,2,3,4,5,7,8,9,10};

        int i = FindMissing(arr,1,10);
        Console.WriteLine(i);

    }


    public static int FindMissing(int[] arr, int start = 1, int end = 100)
    {
        int sourceVal = -1;
        int[] sourceVals = new int[end];
        int ctr = 0;
        for(int i = start; i <= end; i++)
        {
                sourceVals[ctr] = i;
                ctr++;
        }

        
        for(int i = 0; i < sourceVals.Length; i++)
        {
            sourceVal= sourceVals[i];
            bool found = false;

            for(int k = 0; k < arr.Length; k++)
            {
                int missingValue = arr[k];
                if(missingValue == sourceVal)
                {
                    found = true;
                    break;
                }
                    
            }

            if(found)
                continue;
            else
                break;
  
        }

        return sourceVal;
    }


}