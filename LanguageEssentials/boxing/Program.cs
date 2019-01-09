using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> boxed = new List<object>();
            boxed.Add(7);
            boxed.Add(28);
            boxed.Add(-1);
            boxed.Add(true);
            boxed.Add("chair");

            int sum = 0;
            for (int i = 0; i < boxed.Count; i++)
            {
                Console.WriteLine("-" + boxed[i]);
                if(boxed[i] is int)
                {
                    sum +=(int)boxed[i];
                    
                }

            }
            System.Console.WriteLine(sum);
        }
    }
}
