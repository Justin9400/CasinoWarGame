using System;

namespace CasinoWarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();
            Game game = new Game(player, dealer, deck);
            game.startGame();
        }
    }
}
