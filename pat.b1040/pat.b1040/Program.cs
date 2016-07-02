using System;

namespace pat.b1040
{
    /// <summary>
    /// 1040. 有几个PAT（25）
    /// pat.b1040
    /// 2016.06.30
    /// by xy
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        //1000000007
        //2147483647 (int.MaxValue)
        //由于结果可能比较大，只输出对1000000007取余数的结果。   
        //int.MaxValue               2147483647
        // 50000*50000超过了int范围

        private static void Process()
        {
            char[] list = Console.ReadLine().ToCharArray();

            /*
             *思路:顺序遍历，计算P个数，如果碰到A把计数赋给A(A前的P个数)；逆序遍历，计算T个数，如果碰到A把计数赋给A(A后的T个数)
             *顺序遍历，计算所有P个数*T个数，求和
             */

            int pCount = 0;
            Int64[] P = new Int64[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == 'P')
                {
                    pCount++;
                }
                if (list[i] == 'A')
                {
                    P[i] = pCount;
                }
            }

            decimal sum = 0;

            int tCount = 0;
            Int64[] T = new Int64[list.Length];
            for (int i = list.Length - 1; i >= 0; i--)
            {
                if (list[i] == 'T')
                {
                    tCount++;
                }
                if (list[i] == 'A')
                {
                    sum += (P[i] * tCount) % 1000000007;
                    sum %= 1000000007;
                }
            }

            Console.WriteLine(sum);
        }
    }
}