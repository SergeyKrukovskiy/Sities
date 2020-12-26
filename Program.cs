using System;
using System.Collections.Generic;

namespace Sities
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Sity = new List<string>();
            string s = Console.ReadLine();
            Sity.Add(s);
            while (true)
            {
                string c = Sity[Sity.Count - 1];
                s = Console.ReadLine();
                if (c[c.Length-1].ToString().ToLower() != s[0].ToString().ToLower())
                {
                    Console.WriteLine("Неправильно подобран город!");
                }
                if (Sity.Contains(s))
                {
                    Console.WriteLine("Такой город уже был!");
                }
                else
                {
                    Sity.Add(s);
                }
            }
        }
    }
}
