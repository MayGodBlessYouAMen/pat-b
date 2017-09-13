using System;

namespace pat.b1063
{
    /// <summary>
    /// pat.b1063. 计算谱半径(20)
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
            int n = int.Parse(Console.ReadLine());
            double r = 0;
            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split(' ');
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                double temp = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2);
                if (r < temp)
                {
                    r = temp;
                }
            }
            Console.WriteLine(r.ToString("0.00"));
        }

    }
}
