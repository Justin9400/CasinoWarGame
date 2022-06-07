using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        List<string> unshuffledDeck = new List<string>
        {
            "ACE OF SPADES",
            "TWO OF SPADES",
            "THREE OF SPADES",
            "FOUR OF SPADES",
            "FIVE OF SPADES",
            "SIX OF SPADES",
            "SEVEN OF SPADES",
            "EIGHT OF SPADES",
            "NINE OF SPADES",
            "TEN OF SPADES",
            "JACK OF SPADES",
            "QUEEN OF SPADES",
            "KING OF SPADES",
            "ACE OF HEARTS",
            "TWO OF HEARTS",
            "THREE OF HEARTS",
            "FOUR OF HEARTS",
            "FIVE OF HEARTS",
            "SIX OF HEARTS",
            "SEVEN OF HEARTS",
            "EIGHT OF HEARTS",
            "NINE OF HEARTS",
            "TEN OF HEARTS",
            "JACK OF HEARTS",
            "QUEEN OF HEARTS",
            "KING OF HEARTS",
            "ACE OF DIAMONDS",
            "TWO OF DIAMONDS",
            "THREE OF DIAMONDS",
            "FOUR OF DIAMONDS",
            "FIVE OF DIAMONDS",
            "SIX OF DIAMONDS",
            "SEVEN OF DIAMONDS",
            "EIGHT OF DIAMONDS",
            "NINE OF DIAMONDS",
            "TEN OF DIAMONDS",
            "JACK OF DIAMONDS",
            "QUEEN OF DIAMONDS",
            "KING OF DIAMONDS",
            "ACE OF CLUBS",
            "TWO OF CLUBS",
            "THREE OF CLUBS",
            "FOUR OF CLUBS",
            "FIVE OF CLUBS",
            "SIX OF CLUBS",
            "SEVEN OF CLUBS",
            "EIGHT OF CLUBS",
            "NINE OF CLUBS",
            "TEN OF CLUBS",
            "JACK OF CLUBS",
            "QUEEN OF CLUBS",
            "KING OF CLUBS"
        };
        List<string> shuffledDeck = new List<string>
        {
            "SEVEN OF SPADES",
            "FOUR OF HEARTS",
            "NINE OF DIAMONDS",
            "THREE OF HEARTS",
            "TWO OF HEARTS",
            "TEN OF HEARTS",
            "JACK OF SPADES",
            "EIGHT OF CLUBS",
            "TEN OF SPADES",
            "KING OF HEARTS",
            "SEVEN OF HEARTS",
            "ACE OF SPADES",
            "THREE OF CLUBS",
            "SIX OF SPADES",
            "THREE OF SPADES",
            "ACE OF DIAMONDS",
            "EIGHT OF HEARTS",
            "TWO OF SPADES",
            "QUEEN OF SPADES",
            "TWO OF CLUBS",
            "NINE OF CLUBS",
            "TEN OF DIAMONDS",
            "QUEEN OF CLUBS",
            "FOUR OF CLUBS",
            "ACE OF CLUBS",
            "SIX OF DIAMONDS",
            "QUEEN OF HEARTS",
            "FIVE OF SPADES",
            "FOUR OF DIAMONDS",
            "FIVE OF DIAMONDS",
            "SIX OF CLUBS",
            "FIVE OF HEARTS",
            "JACK OF DIAMONDS",
            "THREE OF DIAMONDS",
            "JACK OF CLUBS",
            "SIX OF HEARTS",
            "KING OF CLUBS",
            "TWO OF DIAMONDS",
            "SEVEN OF CLUBS",
            "TEN OF CLUBS",
            "FIVE OF CLUBS",
            "JACK OF HEARTS",
            "EIGHT OF SPADES",
            "KING OF SPADES",
            "FOUR OF SPADES",
            "QUEEN OF DIAMONDS",
            "SEVEN OF DIAMONDS",
            "ACE OF HEARTS",
            "NINE OF SPADES",
            "NINE OF HEARTS",
            "EIGHT OF DIAMONDS",
            "KING OF DIAMONDS"
        };
        List<string> gameDeck = new List<string>
        {
            "TEN OF HEARTS",
            "KING OF CLUBS",
            "TWO OF CLUBS",
            "ACE OF CLUBS",
            "TWO OF SPADES",
            "FOUR OF DIAMONDS",
            "NINE OF SPADES",
            "TWO OF DIAMONDS",
            "FIVE OF SPADES",
            "FOUR OF HEARTS",
            "QUEEN OF DIAMONDS",
            "ACE OF HEARTS",
            "FIVE OF DIAMONDS",
            "NINE OF HEARTS",
            "SIX OF CLUBS",
            "KING OF DIAMONDS",
            "THREE OF SPADES",
            "FOUR OF SPADES",
            "SIX OF HEARTS",
            "TEN OF CLUBS",
            "ACE OF DIAMONDS",
            "THREE OF HEARTS",
            "QUEEN OF SPADES",
            "KING OF HEARTS",
            "NINE OF DIAMONDS",
            "JACK OF DIAMONDS",
            "SEVEN OF DIAMONDS",
            "TEN OF DIAMONDS",
            "TWO OF HEARTS",
            "JACK OF SPADES",
            "ACE OF SPADES",
            "EIGHT OF SPADES",
            "SEVEN OF SPADES",
            "KING OF SPADES",
            "EIGHT OF CLUBS",
            "SEVEN OF HEARTS",
            "TEN OF SPADES",
            "JACK OF HEARTS",
            "FIVE OF HEARTS",
            "FIVE OF CLUBS",
            "EIGHT OF DIAMONDS",
            "SEVEN OF CLUBS",
            "SIX OF SPADES",
            "EIGHT OF HEARTS",
            "SIX OF DIAMONDS",
            "THREE OF CLUBS",
            "QUEEN OF HEARTS",
            "NINE OF CLUBS",
            "THREE OF DIAMONDS",
            "JACK OF CLUBS",
            "QUEEN OF CLUBS",
            "FOUR OF CLUBS"
        };

        [TestMethod]
        public void T00_Create_Stack()
        {
            Stack myStack = new Stack();
            Assert.AreEqual(null, myStack._top);
        }

        [TestMethod]
        public void T01_Add_To_Stack()
        {
            Stack myStack = new Stack();
            Card myCard = new Card(Card.Rank.ACE, Card.Suit.SPADES);
            myStack.push(myCard);
            Assert.AreEqual(myStack.count, 1);
        }

        [TestMethod]
        public void T02_Pop_Peek_Stack()
        {
            Stack myStack = new Stack();
            Card myCard = new Card(Card.Rank.ACE, Card.Suit.SPADES);
            myStack.push(myCard);


            Card peekCard = myStack.peek();
            Assert.AreEqual(peekCard, myCard);


            Card popCard = myStack.pop();
            Assert.AreEqual(popCard, myCard);
        }

        [TestMethod]
        public void T03_Create_Unshuffled_Deck()
        {
            Deck deck = new Deck();
            deck.createDeck();
            int i = 0;

            foreach (Card card in deck.deckList)
            {
                Assert.AreEqual(unshuffledDeck[i], card.cardToString());
                i++;
            }
        }

        [TestMethod]
        public void T04_Create_Shuffled_Deck()
        {
            Deck deck = new Deck(97341);
            deck.createDeck();
            deck.shuffle();
            int i = 0;

            foreach (Card card in deck.deckList)
            {
                Assert.AreEqual(shuffledDeck[i], card.cardToString());
                i++;
            }
        }

        [TestMethod]
        public void T05_Run_Game()
        {
            Deck deck = new Deck(15839275);
            Card card = new Card();
            deck.createDeck();
            deck.shuffle();
            int i = 0;

            //Checks if the seed produces the correct deck
            foreach (Card _card in deck.deckList)
            {
                Assert.AreEqual(gameDeck[i], _card.cardToString());
                i++;
            }

            //Create new player, dealer, and game
            Player player = new Player();
            Dealer dealer = new Dealer();
            Game game = new Game();


            for (int j = 0; j < 26; j++)
            {
                player.addToPlayerHand(deck.drawCard());
                dealer.addToDealerHand(deck.drawCard());

                int result = card.Compare(player.playerHand[0].rank, dealer.dealerHand[0].rank);

                //If the Dealer has a higher card 
                if (result == -1)
                {
                    dealer.wins++;
                }
                //If the dealer and the user have the same rank card
                else if (result == 0)
                {
                    bool inWar = true;
                    int k = 1;
                    //Begin war
                    while (inWar == true)
                    {
                        //Add a card to the dealer and the players hands
                        player.addToPlayerHand(deck.drawCard());
                        dealer.addToDealerHand(deck.drawCard());
                        //Compare the most recent card in each of their hands 
                        result = card.Compare(player.playerHand[k].rank, dealer.dealerHand[k].rank);

                        //If the dealer has a greater rank 
                        if (result == -1)
                        {
                            dealer.wins++;
                            inWar = false;
                        }
                        //If the dealer and the player have the same rank
                        else if (result == 0)
                        {
                            k++;
                        }
                        //If the player has a higher rank card
                        else if (result == 1)
                        {
                            player.wins++;
                            inWar = false;
                        }
                    }
                }
                //If the player has a higher rank card
                else if (result == 1)
                {
                    player.wins++;
                }
                //Clear their hands 
                player.clearPlayerHand();
                dealer.clearDealerHand();
            }

            //Checks if the player and dealer have the correct scores after the game
            Assert.AreEqual(player.wins, 9);
            Assert.AreEqual(dealer.wins, 17);
        }

    }
}
