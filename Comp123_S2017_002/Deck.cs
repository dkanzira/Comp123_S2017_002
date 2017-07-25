using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 25, 2017
 * Description: This is the Card Class
 * Version: 0.2 - Added a shuffle method
 */
namespace Comp123_S2017_002
{
    public class Deck:List<Card>
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private Random _random;
        //PUBLIC PROPERITIES

        //PRIVATE PROPERTIES
        private Random Random
        {
            get
            {
                return this._random;
            }
        }
        
        //CONSTRUCTORS -----------------------------------------------------

        /// <summary>
        /// This is the main constructor
        /// </summary>
        public Deck()
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// This is the initalize method, it sets values for private 
        /// </summary>
        private void _initialize()
        {
            //initialize the pseudo-random number generator
            this._random = new Random();

            //This builds the deck - fills it with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }

            }
            
        }
        //PUBLIC METHODS
        /// <summary>
        /// This method overrides the built-in To String method.
        /// </summary>
        /// <returns>This method returns the current cards in the deck</returns>
        public override string ToString()
        {
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards at a time
        /// it uses a Fisher Gates like algorithim
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);

                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
    }
}