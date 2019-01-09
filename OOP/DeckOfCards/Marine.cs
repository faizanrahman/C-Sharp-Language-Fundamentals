using System;
using System.Linq;

namespace DeckOfCards
{
    public class Marine
    {
        private int Print(){
            System.Console.WriteLine("Steph Curry");
            System.Console.WriteLine($"{strength}");
            strength++;
            return strength;
        }
        public int Klay(){
            return Print();
        }
        public int strength = 5;
    }
}