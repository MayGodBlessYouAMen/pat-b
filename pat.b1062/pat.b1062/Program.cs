using System;
using System.Collections.Generic;

namespace pat.b1062
{
    /// <summary>
    /// pat.b1062. 最简分数(20)
    /// 2017.09.13
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
            //输入格式： N1/M1 N2/M2 M
            string[] args = Console.ReadLine().Split(' ');

            string[] args1 = args[0].Split('/');
            int n1 = int.Parse(args1[0]);
            int m1 = int.Parse(args1[1]);

            string[] args2 = args[1].Split('/');
            int n2 = int.Parse(args2[0]);
            int m2 = int.Parse(args2[1]);

            int m = int.Parse(args[2]);

            /* 给定N1/M1，N2/M2，给定N/M中的M，求合适的N
             * 分析：
             * 1.(N1/M1)<(N/M)<(N2/M2)
             *   增加：(N1/M1)>(N/M)>(N2/M2)
             * 2.N和M即最大公约数为1(可以用辗转相除法求)
             */

            List<int> nlist = new List<int>();
            for (int n = 1; n < m; n++)
            {
                if (InRange(n1, m1, n, m, n2, m2) && IsSimplestFraction(n, m))
                {
                    nlist.Add(n);
                }
            }

            //题目保证至少有1个输出,不用判断空
            for (int i = 0; i < nlist.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(string.Format("{0}/{1}", nlist[i], m));
                }
                else
                {
                    Console.Write(string.Format(" {0}/{1}", nlist[i], m));
                }
            }
        }

        /// <summary>
        /// 判断(N1/M1)<(N/M)<(N2/M2)
        /// 增加：或者(N1/M1)>(N/M)>(N2/M2)
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="m1"></param>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="n2"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        private static bool InRange(int n1, int m1, int n, int m, int n2, int m2)
        {
            //增加：由于没有规定左右哪个大。所以应该有两种情况
            if (n1 * m < m1 * n && n * m2 < m * n2 || 
                n1 * m > m1 * n && n * m2 > m * n2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 判断N和M即最大公约数为1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        private static bool IsSimplestFraction(int n, int m)
        {
            int a = m;
            int b = n;
            //辗转相除法
            while (true)
            {
                int c = a % b;
                if (c == 0)
                {
                    if (b == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    a = b;
                    b = c;
                }
            }
        }
    }
}
