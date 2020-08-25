using System.Collections.Generic;

namespace Blackjack
{

    /* Example of a class.
    * Classes define the inforamtion of an object to be instantiated. 
    * 
    * Hand class is made up of a list of cards in which you can: add cards, clear cards, and determine the value of all the entire hand.
    */
    class Hand
    {
        //Private feilds
        private List<Card> hand = new List<Card>();


        //Public Properties
        public int HandValue { get { return caluclateHandValue(); } }
        public int CardCount { get { return hand.Count; } } //5-card Charlie rule 5 players wins if they have 5 cards


        //Public Methods
        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public Card GetCardInHand(int index)
        {
            return hand[index];
        }

        public void ClearHand() { this.hand = new List<Card>(); }


        //Private Methods
        private int caluclateHandValue()
        {
            int value = 0;
            int numberOfAces = 0;

            //Adds value hand for every card except ace
            foreach (Card card in hand)
            {
                if (card.CardValue > 1) //Check for ace
                    value += card.CardValue;
                else
                    numberOfAces++;
            }

            //Checks and adds aces as they can be 1 or 11
            for (int i = 0; i < numberOfAces; i++)
                value = ((value + 11) > 21) ? value++ : value += 11;

            return value;
        }


        //Static Methods
        public static int CompareHands(Hand player1, Hand player2)
        {
            if (player1.HandValue == player2.HandValue)
                return 0;

            if (player1.HandValue > player2.HandValue)
                return 1;

            return 2;
        }

    }
}
