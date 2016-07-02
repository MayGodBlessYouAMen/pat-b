using System;

namespace pat.b1007
{
    /// <summary>
    /// 1007. 素数对猜想 (20)
    /// pat.b1007
    /// 2016.05.31
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
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 1; i <= n - 2; i++)
            {
                if (IsPrime(i) && IsPrime(i + 2))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
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
