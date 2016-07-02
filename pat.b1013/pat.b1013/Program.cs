using System;
using System.Collections.Generic;

namespace pat.b1013
{
    /// <summary>
    /// 1013. 数素数 (20)
    /// pat.b1013
    /// 2016.06.10 update
    /// by xy
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Proecess();
        }

        private static void Proecess()
        {
            string[] args = Console.ReadLine().Split(' ');
            int M = Convert.ToInt32(args[0]);
            int N = Convert.ToInt32(args[1]);
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 2; i <= 110000; i++)     //第10000个素数是104729
            {
                if (IsPrime(i))
                {
                    count++;
                    if (count >= M)
                    {
                        list.Add(i);
                    }

                    if (count >= N)
                    {
                        break;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                if ((i + 1) % 10 == 0 && i < list.Count - 1)
                {
                    str += list[i];
                    Console.WriteLine(str);
                    str = "";
                }
                else if (i == list.Count - 1)
                {
                    str += list[i];
                    Console.WriteLine(str);
                    str = "";
                }
                else
                {
                    str += list[i] + " ";
                }
            }
        }

        //判断素数(除了1和它本身，没有其他的约数)
        private static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n == 2 || n == 3)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
