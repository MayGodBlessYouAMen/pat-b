using System;

namespace pat.b1051
{
    /// <summary>
    /// 1051. 复数乘法 (15)
    /// pat.b1051
    /// 2016.06.06 create
    /// 2016.06.10 update
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
            double R1 = Double.Parse(args[0]);
            double P1 = Double.Parse(args[1]);
            double R2 = Double.Parse(args[2]);
            double P2 = Double.Parse(args[3]);
            double A = R1 * R2 * (Math.Cos(P1) * Math.Cos(P2) - Math.Sin(P1) * Math.Sin(P2));
            double B = R1 * R2 * (Math.Cos(P1) * Math.Sin(P2) + Math.Sin(P1) * Math.Cos(P2));
            A = Math.Round(A, 2, MidpointRounding.AwayFromZero);
            B = Math.Round(B, 2, MidpointRounding.AwayFromZero);

            if (B < 0)
            {
                Console.WriteLine(string.Format("{0}{1}i", A.ToString("#0.00"), B.ToString("#0.00")));
            }
            else
            {
                Console.WriteLine(string.Format("{0}+{1}i", A.ToString("#0.00"), B.ToString("#0.00")));
            }
        }
    }
}
