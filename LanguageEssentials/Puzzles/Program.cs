using System;
using System.Collections.Generic;

namespace Puzzles {
    class Program {

        public static int[] RandomArray () {
            Random rand = new Random ();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++) {
                arr[i] = rand.Next (5, 25);
            }
            int sum = 0;
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++) {

                sum += arr[i];
                // System.Console.WriteLine(arr[i]);
                if (arr[i] < min) {
                    min = arr[i];
                }
                if (arr[i] > max) {
                    max = arr[i];
                }
            }

            System.Console.WriteLine (min);
            System.Console.WriteLine (max);
            System.Console.WriteLine (sum);
            return arr;
        }

        public static string tossCoin () {
            System.Console.WriteLine ("Tossing a Coin!");
            Random rand = new Random ();
            int outcome = rand.Next (0, 2);
            if (outcome == 0) {
                System.Console.WriteLine ("Heads");
            } else {
                System.Console.WriteLine ("Tails");
            }
            System.Console.WriteLine ($"The result is {outcome}");
            return $"{outcome}";
        }

        public static double tossMultipleCoins (int num) {
            double headCount = 0;
            double tailCount = 0;
            for (int i = 0; i < num; i++) {
                string result = tossCoin ();
                int result2 = System.Convert.ToInt32 (result);
                if (result2 == 0) {
                    headCount++;
                } else {
                    tailCount++;
                }
            }
            System.Console.WriteLine (headCount);
            System.Console.WriteLine (tailCount);
            double ratio = headCount / tailCount;
            System.Console.WriteLine ("----------------");
            System.Console.WriteLine (ratio);
            return ratio;
        }

        public static string[] Names () {
            string[] names = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            // Shuffle the array 
            Random rand = new Random ();
            for (int i = 0; i < names.Length; i++) {
                int generatedNum = rand.Next (0, names.Length);
                string temp = names[i];
                names[i] = names[generatedNum];
                names[generatedNum] = temp;
            }

            for (int i = 0; i < names.Length; i++) {
                System.Console.WriteLine (names[i]);
            }

            // string[] newArray = [];
            List<string> newList = new List<string> ();
            for (int i = 0; i < names.Length; i++) {
                if (names[i].Length > 5) {
                    newList.Add (names[i]);
                }
            }
            string[] newArray = new string[newList.Count];
            for (var idx = 0; idx < newList.Count; idx++) {
                newArray[idx] = newList[idx];
                System.Console.WriteLine (newArray[idx]);
            }

            return newArray;
        }
    
        static void Main (string[] args) {
            RandomArray ();
            tossCoin ();
            tossMultipleCoins (15);
            Names ();
        }
    }
}

