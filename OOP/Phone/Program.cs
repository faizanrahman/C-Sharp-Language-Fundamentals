using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile","Do Doo dooo");
            Nokia elevenHundred = new Nokia("1100", 60, "MetroPCS","Ring ring rinnnnnnnngggggg"); 
            s8.DisplayInfo();
            s8.Ring();
            s8.Unlock();
            System.Console.WriteLine("");

            elevenHundred.DisplayInfo();
            elevenHundred.Ring();
            elevenHundred.Unlock();
            System.Console.WriteLine("");

        }
    }
}
