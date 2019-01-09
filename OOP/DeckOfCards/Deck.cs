using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {   
        string[] stringVals = new string[] {"Ace", "2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        string[] suits = new string[]
        {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"
        };
        public List<Card> cards = new List<Card>();
        public Deck()
        {
            foreach (var suit in suits)
            {
                int numVal = 1;
                foreach (var stringVal in stringVals)
                {
                    //System.Console.WriteLine(stringVal);
                    Card newCard = new Card(stringVal, suit, numVal);
                    cards.Add(newCard);
                    numVal++;
                }
            }
        }
        public void readDeck()
        {
            foreach (Card card in cards)
            {
                System.Console.WriteLine($"{card.StringVal} of {card.Suit}");
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i < cards.Count;i++)
            {
                int newIndex = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[newIndex];
                cards[newIndex] = temp;
            }
        }
        public Card Deal()
        {
            Card dealtCard = cards[0];
            cards.Remove(dealtCard);
            return dealtCard; 
        }

        public void Reset()
        {
            cards = new List<Card>();
            Console.WriteLine(cards.Count);
            foreach (var suit in suits)
            {
                int numVal = 1;
                foreach (var stringVal in stringVals)
                {
                    //System.Console.WriteLine(stringVal);
                    Card newCard = new Card(stringVal, suit, numVal);
                    cards.Add(newCard);
                    numVal++;
                }
            }
            Console.WriteLine(cards.Count);
        }

    }
}