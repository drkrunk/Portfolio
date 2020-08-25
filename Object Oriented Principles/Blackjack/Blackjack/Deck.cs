using System.Collections.Generic;

namespace Blackjack
{
    /* Example of a class.
    * Classes define the inforamtion of an object to be instantiated. 
    * 
    * Deck class is made up of a list of cards that can be shuffled.
    */
    class Deck
    {
        private List<Card> cards;

        public bool IsEmpty { get { return (Cards.Count == 0); } }

        public List<Card> Cards { get => cards; set => cards = value; }

        //Creates a new list of cards, generates a standard 52 card deck, and shuffles a deck.
        public Deck(bool isFullDeck = true)
        {
            Cards = new List<Card>();

            if (isFullDeck)
            {
                generateDeck();
                shuffleDeck();
            }

        }

        public Deck(List<Card> cards)
        {
            this.Cards = cards;
            shuffleDeck();
        }

        public Card DrawCard()
        {
            if (Cards.Count == 0) return null;

            Card card = Cards[0];
            Cards.Remove(card);
            return card;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        //Creats cards by looping through the suits and each number
        private void generateDeck()
        {

            for (int suit = 0; suit < 4; suit++)
            {
                for (int num = 1; num < 14; num++)
                {
                    Card card = new Card(num, (Suits)suit);
                    Cards.Add(card);
                }
            }
        }

        //Randomizes deck by removing card at random index and placing it at the back of the deck
        private void shuffleDeck()
        {
            System.Random rand = new System.Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int randomIndex = rand.Next(Cards.Count);


                Card tempCard = Cards[i];
                Cards[i] = Cards[randomIndex];
                Cards[randomIndex] = tempCard;

            }
        }
    }
}
