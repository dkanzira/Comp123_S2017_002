using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList Abstract class
 * Version: 0.2 - Added the Highest Card method
 */
namespace Comp123_S2017_002
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS
        protected override void _initialize()
        {
            // STUB
            // this method is empty
        }
        // PUBLIC METHODS
         /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {

            string outputString = "";
            outputString += "Hand Contains  Number of Cards: " + this.Count + "\n";
            outputString += "==================================\n";
            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }
        public void HighestCards()
        {
            var pick = from cards in hand2
                       orderby cards.Face descending
                       select cards;
        }
        }
}