using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoPlayerWF
{
    public class BingoGame
    {
        public static List<string> Items;
        public static Random random;

        List<string> CurrentItems;
        int Current;

        static BingoGame()
        {
            random = new Random();
            Items = new List<string>();
            Items.AddRange(Enumerable.Range(1, 15).Select(x => "B\n" + x.ToString()));
            Items.AddRange(Enumerable.Range(16, 15).Select(x => "I\n" + x.ToString()));
            Items.AddRange(Enumerable.Range(31, 15).Select(x => "N\n" + x.ToString()));
            Items.AddRange(Enumerable.Range(46, 15).Select(x => "G\n" + x.ToString()));
            Items.AddRange(Enumerable.Range(61, 15).Select(x => "O\n" + x.ToString()));

        }

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public BingoGame()
        {
            Current = 0;
            CurrentItems = new List<string>(Items);
            Shuffle(CurrentItems);
        }

        public bool HasMore
        {
            get
            {
                return Current < CurrentItems.Count;
            }
        }
        public string GetNext()
        {
            if (Current < CurrentItems.Count)
                return CurrentItems[Current++];
            return "";
        }

    }
}
