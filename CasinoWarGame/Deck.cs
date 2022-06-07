using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static CasinoWarGame.Card;

namespace CasinoWarGame
{
    public class Deck : Card//: IDeck
    {
        public List<Card> deckList;
        public Stack deck;
        private Random _random;
        public int size { get; set; }

        //Default constructor
        public Deck()
        {
            this.deck = new Stack();
            this._random = new Random();
            this.deckList = new List<Card>();
        }

        //Constructor that takes in a seed to test shuffles 
        public Deck(int seed)
        {
            this.deck = new Stack();
            this._random = new Random(seed);
            this.deckList = new List<Card>();
        }

        //Constructor that takes in a custom deck list for testing
        public Deck(List<Card> list)
        {
            this.deck = new Stack();
            this._random = new Random();
            this.deckList = list;

            //Push the contents of the deck list from the end to the beginning 
            //To compensate for the stacks LIFO property
            for (int i = deckList.Count - 1; i >= 0; i--)
                deck.push(deckList[i]);
        }

        //Creates a standard unshuffled deck
        public void createDeck()
        {
            this.deckList = new List<Card>(); //Reset the deck list
            this.deck = new Stack(); //Reset the deck stack
            //Create a standard deck that is in order and store it in the deck list
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card(rank, suit);
                    deckList.Add(card);
                }
            }
            //Push the contents from the deck list to the deck stack
            for (int i = deckList.Count - 1; i >= 0; i--)
                deck.push(deckList[i]);
            //Set the size of the deck
            size = 52;
        }

        public void shuffle()
        {
            //For every card in the deck
            //Get random number between 0 and 51
            //Swap current index with the random number index
            for (int i = 0; i < deck.count; i++)
            {
                int randomIndex = _random.Next(0, 52);
                Card temp = deckList[i];
                deckList[i] = deckList[randomIndex];
                deckList[randomIndex] = temp;
                //swap(i, randomIndex);
            }
            //Push the shuffled deck list to the deck stack
            for (int j = 51; j >= 0; j--)
                deck.push(deckList[j]);
        }

        //Pulls a card off the top of the stack
        //Decrements the size
        public Card drawCard()
        {
            size--;
            return deck.pop();
        }

        //Shows what the top card is 
        public Card getTopCard()
        {
            return deck.peek();
        }

        //Converts the card rank and suit from and enum to a string
        public string cardToString(Card card)
        {
            string cardString = (card.rank).ToString() + " OF " + (card.suit).ToString(); //Console.WriteLine(rank + " OF " + suit);
            return cardString;
        }

        //Prints the each card to a string 
        public void deckToString()
        {
            foreach (Card card in deckList)
            {
                string rank = (card.rank).ToString();
                string suit = (card.suit).ToString();
                Console.WriteLine(rank + " OF " + suit);
            }
        }
    }
}
