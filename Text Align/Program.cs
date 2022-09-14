using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Align
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "My name is Farzin Anan Mukit.\nI am 23 years old.\nI am a .Net Developer.\nI love playing guitar.";
            LeftAlign(s);
            RightAlign(s);
            CenterAlign(s);
        }
        public static void LeftAlign(string s)
        {
            List<string> list = new List<string>();
            list = s.Split("\n").ToList();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void RightAlign(string s)
        {
            List<string> list = new List<string>();
            list = s.Split("\n").ToList();
            var MaxLength = 0;
            foreach(string line in list)
            {
                if(line.Length > MaxLength) { MaxLength = line.Length; }
            }
            for(int i= 0; i < list.Count(); i++)
            {
                var currentLngth = list[i].Length;
                while(currentLngth < MaxLength)
                {
                    list[i]=" "+list[i];
                    currentLngth++;
                }
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void CenterAlign(string s)
        {
            List<string> list = new List<string>();
            list = s.Split("\n").ToList();
            var MaxLength = 0;
            foreach (string line in list)
            {
                if (line.Length > MaxLength) { MaxLength = line.Length; }
            }
            for (int i = 0; i < list.Count(); i++)
            {
                var currentLngth = list[i].Length;
                var spaces = (MaxLength - currentLngth)/2;
                while (spaces!=0)
                {
                    list[i] = " " + list[i];
                    spaces--;
                }
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
