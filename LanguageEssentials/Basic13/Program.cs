using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Print255()
        {
            for(int i = 1; i <= 255; i++) 
            {
                Console.WriteLine(i);
            }
        }

        static void Odd255()
        {
            for (int i = 1; i <= 255; i = i + 2)
            {
                System.Console.WriteLine(i);
            }
        }

        static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum = sum + i;
                System.Console.WriteLine($"New Number:{i} Sum: {sum}");
            }   
        }

        static void Iterate(int[] arr)
        {
            foreach (int num in arr)
            {
                System.Console.WriteLine(num);
            }
        }

        static void FindMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if(num > max)
                {
                    max = arr[num];
                }
            }
            System.Console.WriteLine(max);
        }

        static void getAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum+=num;
            }
            int average = sum/arr.Length;
            System.Console.WriteLine(average);
        }

        static List<int> ArrayOddNums()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 256; i++)
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                } 
            }
            return odds;
        }

        static int GreaterThanY(int[] arr, int y)
        {
            int counter = 0;
            foreach (int num in arr)
            {
                if(num > y)
                {
                    counter +=1; 
                }
            }
            System.Console.WriteLine(counter);
            return counter;
        }

        static int[] squaredValues(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {   
                arr[i] = arr[i] * arr[i];
            }
            System.Console.WriteLine(arr);
            return arr;
        } 

        static int[] noNegatives(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            System.Console.WriteLine(arr);
            return arr;
        }

        static void minMaxAverage(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                sum+=arr[i];
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int average = sum/arr.Length;
                System.Console.WriteLine("The min value is " + min + ", The max value is " + max + ", The average value is " + average);
        }

        static void shiftValuesLeft(int[]arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
            
        }
        
        static object[] numberToString(int[] arr)
        {
            object[] output = new object[arr.Length];
            for(int i = 0; i < arr.Length;i++)
            {
                output[i] = arr[i];
                if(arr[i] < 0)
                {
                    output[i] = "Dojo";
                }
                System.Console.WriteLine(output[i]);
            }

            return output; 
        }
        static void Main(string[] args)
        {
            // Print255();
            // Odd255();
            // PrintSum();
            int[] arr = new int[] {4,-5,13,-3,5,22,33,44,55,66};
            //Iterate(arr);
            //FindMax(arr);
            //getAverage(arr);
            // List<int> odds = ArrayOddNums();
            // foreach (var num in odds)
            // {
            //     System.Console.WriteLine(num);
            // }
            //GreaterThanY(arr, 4);
            //squaredValues(arr);
            //noNegatives(arr);
            //minMaxAverage(arr);
            //shiftValuesLeft(arr);
            numberToString(arr);
        }
    }
}
