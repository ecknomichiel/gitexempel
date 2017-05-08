using System;
using System.Collections.Generic;

namespace GitExempel
{
    class WordOfTheDay
    {
        private string[] verbs = { "is", "will be", "was", "has been", "becomes" };
        private string[] nouns = { "today", "this week", "the future", "money", "love" };
        private string[] adjectives = { "great", "lots of potential", "interesting", "rather bad", "ok" };
        private Random rand = new Random();

        public string Text
        {
            get { return String.Format("{0} {1} {2}", nouns[rand.Next(nouns.Length)], 
                                                        verbs[rand.Next(verbs.Length)],
                                                        adjectives[rand.Next(adjectives.Length)]); }
        }

    }
}
