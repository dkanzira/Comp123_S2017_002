using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Dennis Kanzira
 * Date:July 25 2017
 * Description: Project 11 Demo
 * Version: 0.3  Test the Shuffles method
*/
namespace Comp123_S2017_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            Hand hand2 = new Hand();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled");
            Console.WriteLine(deck.ToString());
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand2.Add(deck.Deal5());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            Console.WriteLine(deck.ToString());
            //hand = deck.Deal5(); // moves the top 5 cards from the deck to the hand objectDeck deck = new Deck();
            
        }
    }
}
