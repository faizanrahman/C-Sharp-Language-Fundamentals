using System;
using System.Linq;
using System.Collections.Generic;
namespace DeckOfCards
{
    public class Player
    {
        public string Name{get;set;}
        public List<Card> hand = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck deck)
        {
            Random rand = new Random();
            int randomCard = rand.Next(deck.cards.Count);
            Card drawnCard = deck.cards[randomCard];
            hand.Add(deck.cards[randomCard]);
            deck.cards.RemoveAt(randomCard);
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine(drawnCard.Value);
            System.Console.WriteLine(deck.cards.Count);
            return drawnCard;    
        }

        public Object Discard(int x)
        {   
            if(x > hand.Count)
            {
                //System.Console.WriteLine("There is no value in the list");
                return null;
            }
            else
            {
            Card discardedCard = hand[x];
            hand.RemoveAt(x);
            //System.Console.WriteLine("The value of the card discarded");
            // System.Console.WriteLine(hand[x].Value);
            // System.Console.WriteLine(hand.Count);
            return discardedCard;
            }
        }
    }
}