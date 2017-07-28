using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 25, 2017
 * Description: This is the Card Class
 * Version: 0.5 - Added a new method called Deal5
 */
namespace Comp123_S2017_002
{
    public class Deck:CardList
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS) -------------------------------
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
   
        //PRIVATE METHODS --------------------------------------------------
        /// <summary>
        /// This is the initalize method, it sets values for private 
        /// </summary>
        protected override void _initialize()
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
        //PUBLIC METHODS ---------------------------------------------------
        /// <summary>
        /// This method overrides the built-in To String method.
        /// </summary>
        /// <returns>This method returns the current cards in the deck</returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "Deck Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";
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
                Card.Overwrite(this[secondCard], this[firstCard]);
                Card.Overwrite(this[firstCard], tempCard);
            }
        }
        /// <summary>
        /// This method returns the top card of the Deck
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); //this removes the top card from the deck

            //for testing /debugging only
            Console.WriteLine("Dealt 1 card - Size of Deck:"+this.Count);
            return topCard;
        }
        /// <summary>
        /// This method deals 5 cards from the top of the deck
        /// </summary>
        /// <returns></returns>
        public Hand Deal5()
        {
            Hand handfive = new Hand();
            for (int i = 0; i <=5; i++)
            {
                Card topCards = this[0];
                handfive.Add(this[0]);
                this.RemoveAt(5);
            }
            return handfive;
           
          //  Console.WriteLine("Dealt 5 card - Size of Deck:" + this.Count);
           
        }

    }
}