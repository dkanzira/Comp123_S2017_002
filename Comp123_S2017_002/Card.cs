using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 25, 2017
 * Description: This is the Card Class
 * Version: 0.3 - Added the overwrite method
 */
namespace Comp123_S2017_002
{
    public class Card : ICloneable
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS) -------------------------------
        private Face _face;
        private Suit _suit;
        //PUBLIC PROPERITIES -----------------------------------------------
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }
        //CONSTRUCTORS -----------------------------------------------------
        /// <summary>
        /// It takes two parameters - face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face,Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //PRIVATE METHODS

        //PUBLIC METHODS
        /// <summary>
        /// This method overrides the built in method
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }
        /// <summary>
        /// This method takes the properties of the first card and overwrites the properties of the second card
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void Overwrite(Card first,Card second)
        {
            second.Face = second.Face;
            second.Suit = second.Suit;
        }

    }
}