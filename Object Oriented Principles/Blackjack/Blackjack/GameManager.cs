namespace Blackjack
{
    /* Example of a class.
   * Classes define the inforamtion of an object to be instantiated. 
   * 
   * GameManger class is responsible for communication to the form as well as hold the game logic.
   */
    class GameManager
    {
        private Hand dealer;
        private Hand player;

        private Deck drawDeck;
        private Deck discardDeck;

        private mainForm parentToCallback;


        //Properties
        public int Wins { get; set; } = 0;
        public int Loses { get; set; } = 0;


        //Constructor
        public GameManager(mainForm displayform)
        {
            dealer = new Hand();
            player = new Hand();

            drawDeck = new Deck();
            discardDeck = new Deck(false);

            parentToCallback = displayform;

            endRound();
        }



        //Public methods
        public void Draw()
        {
            drawCard();
        }

        public void EndTurn()
        {
            doDealerAI();
        }

        public void NewRound()
        {

            parentToCallback.ClearTable();
            discardHand(dealer);
            discardHand(player);

            drawCard(1, true);
            drawCard(1, false);

            drawCard();
            drawCard();

        }



        // Private Methods
        private void drawCard(int playerNumber = 2, bool faceDown = false)
        {
            //Adds discarded cards to the new deck
            if (drawDeck.IsEmpty)
            {
                drawDeck = new Deck(discardDeck.Cards);
                discardDeck = new Deck(false);
            }

            Card card = drawDeck.DrawCard();
            if (playerNumber == 1)
            {
                dealer.AddCard(card);
                if (checkBust(dealer)) { Wins++; endRound();}
                
            }
            else
            {
                player.AddCard(card);
                if (checkBust(player)) { Loses++; endRound();}
                else if (checkFiveCard(player)) { Wins++; endRound();}
            }

            parentToCallback.DisplayNewCard(playerNumber, card, faceDown);

        }


        private bool checkBlackjack(Hand hand)
        {
            return (hand.HandValue == 21 && hand.CardCount == 2);
        }

        private bool checkFiveCard(Hand hand)
        {
            return (hand.CardCount >= 5);
        }

        private void endRound()
        {
            parentToCallback.DisableGUI();
        }

        private bool checkBust(Hand hand)
        {
            return (hand.HandValue > 21);
        }

        private int checkWinner()
        {
            return Hand.CompareHands(dealer, player);
        }

        private void discardHand(Hand hand)
        {
            for (int i = 0; i < hand.CardCount; i++) discardDeck.AddCard(hand.GetCardInHand(i));

            hand.ClearHand();
        }


        //Dealer AI logic
        private void doDealerAI()
        {
            parentToCallback.FlipDealerCard(dealer.GetCardInHand(0));
            if(!checkBlackjack(player))
                while (dealer.HandValue < 17 && !checkBust(dealer)) drawCard(1);

            if (!checkBust(dealer)) {
                if (checkFiveCard(dealer)) { Wins++; endRound(); }
                else if (checkWinner() == 1) { Loses++; }
                else if (checkWinner() == 2) { Wins++; }
            }
            
            endRound();
        }
    }
}
