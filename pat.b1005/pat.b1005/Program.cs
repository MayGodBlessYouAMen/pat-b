using System;
using System.Collections.Generic;

namespace pat.b1005
{
    class Program
    {
        /// <summary>
        /// 1005. 继续(3n+1)猜想 (25)
        /// PAT.b1005
        /// 2016.05.25
        /// by xy
        /// at osaki
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            //read input
            int n = int.Parse(Console.ReadLine());
            string[] args = Console.ReadLine().Split(' ');
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {
                list1.Add(int.Parse(args[i]));
                list2.Add(int.Parse(args[i]));
            }

            //我们称一个数列中的某个数n为“关键数”: 如果n不能被数列中的其他数字所覆盖。
            for (int i = 0; i < list1.Count; i++)
            {
                List<int> list3 = GetChildren(list1[i]);
                for (int j = 0; j < list3.Count; j++)
                {
                    list2.Remove(list3[j]);
                }
            }

            //print
            list2.Sort();
            if (list2.Count > 0)
            {
                string output = "";
                for (int i = list2.Count - 1; i >= 0; i--)
                {
                    if (output != "")
                    {
                        output += " ";
                    }
                    output += list2[i];
                }
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("");
            }
        }

        //求被n覆盖的数列
        private static List<int> GetChildren(int n)
        {
            List<int> list = new List<int>();

            int p = n;
            while (p != 1)
            {
                if (p % 2 == 0)
                {
                    p = p / 2;
                }
                else
                {
                    p = (3 * p + 1) / 2;
                }
                list.Add(p);
            }
            list.Remove(1);
            return list;
        }
    }
}
