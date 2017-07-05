using System;
using System.Collections.Generic;
using System.Text;

namespace pat.b1064
{
    /// <summary>
    /// pat.b1064 朋友数
    /// 2017.07.05
    /// by xy
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
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');

            List<int> sumList = new List<int>();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //按位求和
                sum = SumByBit(int.Parse(arr[i]));
                if (!sumList.Contains(sum))
                {
                    sumList.Add(sum);
                }
            }

            int[] newList = sumList.ToArray();
            //排序
            Array.Sort(newList);

            //朋友证号的个数
            Console.WriteLine(newList.Length);

            //朋友证号
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newList.Length; i++)
            {
                if (i > 0)
                {
                    sb.Append(" ");
                }
                sb.Append(newList[i]);
            }
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// 按位求和
        /// </summary>
        /// <returns></returns>
        private static int SumByBit(int num)
        {
            int sum = 0;

            int n = num;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }

            return sum;
        }
    }
}
