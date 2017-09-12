using System;
using System.Collections.Generic;

namespace pat.b1069
{
    /// <summary>
    /// pat.b1069. 微博转发抽奖(20)
    /// 2017.09.12
    /// by XY
    /// at NingBo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            string[] args = Console.ReadLine().Split(' ');
            //总人数
            int total = int.Parse(args[0]);
            //间隔
            int step = int.Parse(args[1]);
            //第一个序号
            int firstNo = int.Parse(args[2]);

            int n = total;
            List<string> nameList = new List<string>();
            while (n > 0)
            {
                nameList.Add(Console.ReadLine());
                n--;
            }

            if (firstNo > total)
            {
                Console.WriteLine("Keep going...");
            }
            else
            {
                List<string> winnerList = new List<string>();
                int i = firstNo;
                while (i <= total)
                {
                    //可能有人转发多次，但不能中奖多次。所以如果处于当前中奖位置的网友已经中过奖，则跳过他顺次取下一位。
                    string name = nameList[i - 1];
                    if (!winnerList.Contains(name))
                    {
                        Console.WriteLine(name);
                        winnerList.Add(name);
                        i += step;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
