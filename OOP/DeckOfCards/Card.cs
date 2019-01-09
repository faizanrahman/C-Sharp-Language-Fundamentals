using System;
using System.Linq;

namespace DeckOfCards
{
    public class Card
    {
        public string StringVal{get;set;}
        public string Suit{get;set;}
        public int Value{get;set;}

        public Card(string faceValue, string  suitValue, int val)
        {
            StringVal = faceValue;
            Suit = suitValue;
            Value = val;
        }
    }
}