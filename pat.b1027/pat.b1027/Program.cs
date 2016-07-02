using System;

namespace pat.b1027
{
    /// <summary>
    /// 1027. 打印沙漏(20)
    /// pat.b1027
    /// 2016.06.02
    /// by xy
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
            int n = int.Parse(Math.Round(25.0).ToString());
        }

        /// <summary>
        /// 设行数=2*n-1 
        /// 正中间为第1行，上下两头各自为第n行
        /// a(n)=2*n-1
        /// s(n)=(1+3+5+...+2*n-1)*2-1 = n*n*2-1
        /// </summary>
        private static void Process()
        {
            string[] args = Console.ReadLine().Split(' ');
            int total = int.Parse(args[0]);
            string sign = args[1];

            //n*n*2-1<=total --> n<=sqrt((total+1)/2)
            int n = (int)Math.Sqrt((total + 1) / 2);

            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(GetStr(2 * i - 1, 2 * n - 1, sign));
            }
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine(GetStr(2 * i - 1, 2 * n - 1, sign));
            }

            //剩余数字
            Console.WriteLine(total - (n * n * 2 - 1));
        }

        /// <summary>
        /// *记得前后补空格
        /// </summary>
        /// <param name="len"></param>
        /// <param name="maxlen"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        private static string GetStr(int len, int maxlen, string sign)
        {
            string str = "";
            for (int j = 0; j < (maxlen - len) / 2; j++)
            {
                str += " ";
            }
            for (int j = 0; j < len; j++)
            {
                str += sign;
            }
            /*
              for (int j = 0; j < (maxlen - len) / 2; j++)
              {
                  str += " ";
              }
             */
            return str;
        }
    }
}
