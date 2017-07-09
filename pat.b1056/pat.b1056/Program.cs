using System;

namespace pat.b1056
{
    /// <summary>
    /// pat.b1056. 组合数的和(15)
    /// 2017.07.09
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
            #region 思路
            /*
             * 令i从1到n
             * 
             * s[i]=(a[i]*10+a[1]) + ...+ (a[i]*10+a[i-1]) + (a[i]*10+a[i+1]) + ... + (a[i]*10+a[n])
             *     = a[i]*10*(n-1) + a[1]+...+a[i-1]+a[i+1]+...+a[n]
             * 
             * s   =s[1]+...+s[n]
             * 
             *     =a[1]*10*(n-1) + a[2]+           ...+ a[n-1] +          a[n] +
             *      a[1]          + a[2]*10*(n-1) + ...+ a[n-1] +          a[n] +
             *      ... +
             *      a[1]          + a[2]+           ...+ a[n-1]*10*(n-1) + a[n] +
             *      a[1]          + a[2]+           ...+ a[n-1] +          a[n]*10*(n-1) 
             *     
             *     =(a[1]+a[2]+...a[n-1]+a[n])*(n-1)+ (a[1]+a[2]+...a[n-1]+a[n])*10*(n-1)
             *     =(a[1]+a[2]+...a[n-1]+a[n])*11*(n-1)
             */
            #endregion

            string[] arr = Console.ReadLine().Split(' ');

            //数字个数
            int n = int.Parse(arr[0]);
            //n个数字的和
            int temp = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                temp += int.Parse(arr[i]);
            }

            //最终的和
            int s = temp * 11 * (n - 1);

            //输出
            Console.WriteLine(s);
        }
    }
}
