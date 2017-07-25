using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 25, 2017
 * Description: This is the Card Class
 * Version: 0.1 - Created the Card class
 */
namespace Comp123_S2017_002
{
    public class Card
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private Face _face;
        private Suit _suit;

        //PUBLIC PROPERITIES
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
    }
}