using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public class Player
    {
        public List<Card> playerHand;
        public int wins;

        public Player()
        {
            this.playerHand = new List<Card>();
            this.wins = 0;
        }

        public void addToPlayerHand(Card card)
        {
            playerHand.Add(card);
        }

        public void clearPlayerHand()
        {
            this.playerHand.Clear();
        }

    }
}
