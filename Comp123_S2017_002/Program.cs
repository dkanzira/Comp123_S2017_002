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
            Console.WriteLine("This is the original Deck");
            Console.WriteLine("========================================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            Console.WriteLine("========================================================");
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
        }
    }
}
