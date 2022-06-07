using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoWarGame
{
    public class Game
    {
        private Player _player;
        private Dealer _dealer;
        private Deck _deck;
        private Card _card;
        public Game()
        {
            _player = null;
            _dealer = null;
            _deck = null;
            _card = null;
        }

        public Game(Player player, Dealer dealer, Deck deck)
        {
            _player = player;
            _dealer = dealer;
            _deck = deck;
            _card = new Card();
        }

        //Prints the cards in the dealer and the players hands to the console
        public void printHands(int i)
        {
            Console.Write("Player: " + _deck.cardToString(_player.playerHand[i]) + "\n");
            Console.Write("Dealer: " + _deck.cardToString(_dealer.dealerHand[i]) + "\n");
        }

        public void startGame()
        {
            //Create deck and shuffle 
            Console.WriteLine("----------Starting Game----------");
            _deck.createDeck();
            _deck.shuffle();

            char cont = 'Y';

            //While the user wants to continue playing
            while (cont == 'Y' || cont == 'y')
            {
                //Checks if the size of the deck is less than 6
                //So that you do not run out of cards
                if (_deck.size < 6)
                {
                    //Asks the user if they want o continue to play once the deck runs low
                    Console.WriteLine("Out of cards. Do you want to keep playing ('Y' or 'N')? ");
                    char keepPlaying = Console.ReadLine()[0];
                    Console.WriteLine();
                    //If player wants to continue to play then create a new deck and shuffle it 
                    if (keepPlaying == 'Y' || keepPlaying == 'y')
                    {
                        Console.WriteLine("Creating new deck... \n");
                        _deck.createDeck();
                        _deck.shuffle();
                    }
                    //If player does not want to continue to play then write out the score 
                    else
                    {
                        Console.WriteLine("Ending game");
                        Console.WriteLine("Player: " + _player.wins);
                        Console.WriteLine("Dealer: " + _dealer.wins);
                        break;
                    }

                }

                //Deal cards to the dealer and the player
                _player.addToPlayerHand(_deck.drawCard());
                _dealer.addToDealerHand(_deck.drawCard());

                printHands(0);

                int result = _card.Compare(_player.playerHand[0].rank, _dealer.dealerHand[0].rank);

                //If the Dealer has a higher card 
                if (result == -1)
                {
                    Console.WriteLine("Dealer has won!");
                    _dealer.wins++;
                }
                //If the dealer and the user have the same rank card
                else if (result == 0)
                {
                    Console.WriteLine("It is a tie. Time for War!");
                    bool inWar = true;
                    int i = 1;
                    //Begin war
                    while (inWar == true)
                    {
                        //Add a card to the dealer and the players hands
                        _player.addToPlayerHand(_deck.drawCard());
                        _dealer.addToDealerHand(_deck.drawCard());
                        printHands(i);
                        //Compare the most recent card in each of their hands 
                        result = _card.Compare(_player.playerHand[i].rank, _dealer.dealerHand[i].rank);

                        //If the dealer has a greater rank 
                        if (result == -1)
                        {
                            Console.WriteLine("Dealer has won the war");
                            _dealer.wins++;
                            inWar = false;
                        }
                        //If the dealer and the player have the same rank
                        else if (result == 0)
                        {
                            Console.WriteLine("The war continues!");
                            i++;
                        }
                        //If the player has a higher rank card
                        else if (result == 1)
                        {
                            Console.WriteLine("You have won the war");
                            _player.wins++;
                            inWar = false;
                        }
                    }
                }
                //If the player has a higher rank card
                else if (result == 1)
                {
                    Console.WriteLine("You have won!");
                    _player.wins++;
                }
                //Clear their hands 
                _player.clearPlayerHand();
                _dealer.clearDealerHand();

                //Console.WriteLine(_deck.size);
                Console.WriteLine("Would you like to play again? (Y or N)");
                cont = Console.ReadLine()[0];
                Console.WriteLine("");

                //Keeps asking the user if they want to play until either a Y or N is entered
                while (true)
                {
                    if (cont == 'Y' || cont == 'y' || cont == 'N' || cont == 'n')
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a valid choice. Would you like to play again? (Y or N)");
                    cont = Console.ReadLine()[0];
                    Console.WriteLine();
                }
                //If the user chooses to not continue then print out the score
                if (cont == 'N' || cont == 'n')
                {
                    Console.WriteLine("Game Ended");
                    Console.WriteLine("Player: " + _player.wins);
                    Console.WriteLine("Dealer: " + _dealer.wins);
                }
            }
        }
    }
}
