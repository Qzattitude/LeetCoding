using System;
using System.Collections.Generic;

namespace _1352A
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var RoundCount = 0;
            List<int> Rounds = new List<int>();
            int.TryParse(Console.ReadLine(), out int N);
            int[] Counts = new int[N];
            string[] Strings = new string[N];
            
            for(int i = 0; i < N; i++)
            {
                int.TryParse(Console.ReadLine(), out int Number);
                var TempNumber = Number;
                for (int j = 1; j <= Number.ToString().Length; j++)
                {
                    var LastNumber = TempNumber % 10;
                    if (LastNumber != 0)
                    {
                        if (j == 1)
                        {
                            Strings[i] = LastNumber.ToString() + " ";
                            RoundCount++;
                        }
                        else
                        {
                            Strings[i] = Strings[i] + ((int)(LastNumber * Math.Pow(10.0, j-1))).ToString() + " ";
                            RoundCount++;
                        }
                        TempNumber = TempNumber / 10;
                    }
                    else
                    {
                        TempNumber = TempNumber / 10;
                    }
                }
                // Rounds.Add(RoundCount);
                Counts[i] = RoundCount;
                RoundCount = 0;
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(Counts[i]);
                Console.WriteLine(Strings[i]);
            }
        }
    }
}
