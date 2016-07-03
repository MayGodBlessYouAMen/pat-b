using System;
using System.Collections.Generic;

namespace pat.b1032
{
    /// <summary> 
    /// 1032. 挖掘机技术哪家强(20)
    /// pat.b1032
    /// 2016.05.22
    /// by xy
    /// at japan.warabi
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dList = new Dictionary<int, int>();

            while (n > 0)
            {
                n--;

                string[] args = Console.ReadLine().Split(' ');
                int key = int.Parse(args[0]);
                int value = int.Parse(args[1]);

                if (dList.ContainsKey(key))
                {
                    dList[key] += value;
                }
                else
                {
                    dList.Add(key, value);
                }
            }

            int maxKey = 0;
            int maxValue = 0;
            foreach (var dic in dList)
            {
                if (dic.Value > maxValue)
                {
                    maxKey = dic.Key;
                    maxValue = dic.Value;
                }
            }
            Console.WriteLine(string.Format("{0} {1}", maxKey, maxValue));
        }
    }
}
