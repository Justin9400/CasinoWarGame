using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public class Card
    {
        public enum Rank
        {
            ACE = 1,
            TWO = 2,
            THREE = 3,
            FOUR = 4,
            FIVE = 5,
            SIX = 6,
            SEVEN = 7,
            EIGHT = 8,
            NINE = 9,
            TEN = 10,
            JACK = 11,
            QUEEN = 12,
            KING = 13
        }
        public enum Suit
        {
            SPADES = 1,
            HEARTS = 2,
            DIAMONDS = 3,
            CLUBS = 4
        }
        public Rank rank { get; }
        public Suit suit { get; }

        public Card()
        {

        }
        //Constructor that takes in a rank and a suit 
        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public string cardToString()
        {
            string cardName = rank.ToString() + " OF " + suit.ToString();
            return cardName;
        }

        //Compares the rank of two cards
        public int Compare(Rank playerRank, Rank dealerRank)
        {
            int result = 0;
            if (playerRank > dealerRank)
                result = 1;

            else if (playerRank < dealerRank)
                result = -1;

            else if (playerRank == dealerRank)
                result = 0;

            return result;
        }
    }
}
