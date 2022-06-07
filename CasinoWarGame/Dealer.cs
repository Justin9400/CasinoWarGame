using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public class Dealer
    {
        public List<Card> dealerHand;
        public int wins;

        public Dealer()
        {
            this.dealerHand = new List<Card>();
            this.wins = 0;
        }

        public void addToDealerHand(Card card)
        {
            dealerHand.Add(card);
        }

        public void clearDealerHand()
        {
            this.dealerHand.Clear();
        }
    }
}
