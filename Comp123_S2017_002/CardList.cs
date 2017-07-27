using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 27, 2017
 * Description: This is the Abstract CardList Class
 * Version: 0.1 - Created the CardList class
 */
namespace Comp123_S2017_002
{
    public abstract class CardList:List<Card>
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS) -------------------------------

        //PUBLIC PROPERITIES -----------------------------------------------

        //CONSTRUCTORS -----------------------------------------------------
        /// <summary>
        /// This is the main constructor
        /// </summary>
        public CardList()
        {
            this._initialize();
        }
        //PRIVATE METHODS --------------------------------------------------
        protected abstract void _initialize();
        //PUBLIC METHODS ---------------------------------------------------
    }
}