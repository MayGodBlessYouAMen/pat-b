using System;
using System.Collections.Generic;

namespace pat.b1020
{
    /// <summary>
    /// 1020. 月饼 (25)
    /// PAT.b1020
    /// 2016.05.25
    /// by xy
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            string[] args1 = Console.ReadLine().Split(' ');
            string[] args2 = Console.ReadLine().Split(' ');
            string[] args3 = Console.ReadLine().Split(' ');

            int n = int.Parse(args1[0]);
            decimal total = decimal.Parse(args1[1]);
            SortedDictionary<decimal, decimal> dic = new SortedDictionary<decimal, decimal>();
            for (int i = 0; i < n; i++)
            {
                decimal key = Math.Round(decimal.Parse(args3[i]) / decimal.Parse(args2[i]), 5, MidpointRounding.AwayFromZero);
                if (dic.ContainsKey(key))
                {
                    dic[key] += decimal.Parse(args2[i]);
                }
                else
                {
                    dic.Add(key, decimal.Parse(args2[i]));
                }
            }

            decimal sum = 0;
            decimal money = 0;
            List<decimal> keys = new List<decimal>(dic.Keys);
            for (int i = dic.Count - 1; i >= 0; i--)
            {
                if ((sum + dic[keys[i]]) < total)
                {
                    money += Math.Round(keys[i] * dic[keys[i]], 5, MidpointRounding.AwayFromZero);
                    sum += dic[keys[i]];
                }
                else
                {
                    money += Math.Round(keys[i] * (total - sum), 5, MidpointRounding.AwayFromZero);
                    sum = total;
                    break;
                }
            }

            Console.WriteLine(Math.Round(money, 2, MidpointRounding.AwayFromZero).ToString("#.00"));
        }
    }
}
