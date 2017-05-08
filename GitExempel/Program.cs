using System;
using System.Collections.Generic;
using System.Linq;

namespace GitExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            WordOfTheDay wotd = new WordOfTheDay();
            string[] todaysMessages = new string[100];
            for (int i = 0; i < 100; i++ )
            {
                todaysMessages[i] = wotd.Text;
            }

            IEnumerable<string> query =
                from mess in todaysMessages
                where mess.Contains("was")
                select mess.ToString();

            foreach (string s in query)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
