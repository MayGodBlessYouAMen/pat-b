using System;

namespace pat.b1017
{
    /// <summary>
    /// 1017. A除以B (20)
    /// PAT.b1017
    /// 2016.06.02
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
            string[] args = Console.ReadLine().Split(' ');
            string A = args[0];
            int B = int.Parse(args[1]);
            char[] listA = A.ToCharArray();

            /*
             思路：从高位往低位循环，每次读入一位，对B求余得到R；下次循环用R连接读入的1位，凑成两位继续求余。最后的余数就是R
             *     每次对B求商最后串成的字符串就是商Q
             */
            string Q = "";
            int R = 0;
            for (int i = 0; i < listA.Length; i++)
            {
                int a = R * 10 + int.Parse(listA[i].ToString());
                if (i == 0 && a / B == 0 && listA.Length > 1)
                {
                    //第一个0不显示
                }
                else
                {
                    Q += a / B;
                }
                R = a % B;
            }
            Console.WriteLine(string.Format("{0} {1}", Q, R));
        }
    }
}
