using System;
using System.Linq;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //System.Console.WriteLine(deck.cards);
            deck.readDeck();
            deck.Shuffle();
            deck.readDeck();
            //System.Console.WriteLine(deck.Deal());
            deck.Deal();
            deck.Deal();
            deck.Reset();
            Player player1 = new Player("Binh");
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Draw(deck);
            player1.Discard(0);
            player1.Discard(1);
            player1.Discard(20);
        //     Soldier soldier = new Soldier();
        //     Marine marine = new Marine();
        //     System.Console.WriteLine(marine.strength);
        //     System.Console.WriteLine(soldier.strength);
        //     //System.Console.WriteLine(marine.Print());
        //     System.Console.WriteLine(marine.Klay());
        //     System.Console.WriteLine(marine.strength);
        //
        }
    }
}
