namespace Blackjack
{
    /* Example of a class.
    * Classes define the inforamtion of an object to be instantiated. 
    * 
    * Card class holds all the relivant information about the card.
    */
    public enum Suits
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public class Card
    {
        //Number of the card 0 - 13. (0 = ace , 13 = king) 
        private int number = 0;

        public int CardValue { get { return calculateCardValue(); } }
        public int Number { get { return number; } set { number = System.Math.Min(System.Math.Max(value, 0), 13); } }
        public Suits Suit { get; set; }

        public Card(int number, Suits suit)
        {
            this.number = number;
            this.Suit = suit;
        }

        private int calculateCardValue()
        {
            if (number > 10) return 10;
            return number;
        }

        public override string ToString()
        {
            System.String suitString = Suit.ToString();
            return Number + "" + suitString;
        }

    }
}
