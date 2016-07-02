using System;

namespace pat.b1037
{
    /// <summary>
    /// 1037. 在霍格沃茨找零钱（20）
    /// pat.b1037
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
            Console.WriteLine(Subtraction(args[1], args[0]));
        }

        /// <summary>
        /// 计算A-B
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static string Subtraction(string A, string B)
        {
            if (IsAGreaterThanOrEqualB(A, B))
            {
                return GetSunbtraction(A, B);
            }
            else if (A == B)
            {
                return "0.0.0";
            }
            {
                return "-" + GetSunbtraction(B, A);
            }

            throw new NotImplementedException();
        }

        private static int ToInt(string p)
        {
            return int.Parse(p);
        }

        /// <summary>
        /// A>B reurn true
        /// A<=B return false
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static bool IsAGreaterThanOrEqualB(string A, string B)
        {
            string[] listA = A.Split('.');
            string[] listB = B.Split('.');
            if ((ToInt(listA[0]) > ToInt(listB[0]) ||
                (ToInt(listA[0]) == ToInt(listB[0]) && ToInt(listA[1]) > ToInt(listB[1])) ||
                ToInt(listA[0]) == ToInt(listB[0]) && ToInt(listA[1]) == ToInt(listB[1]) && ToInt(listA[2]) >= ToInt(listB[2])))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 只接受A>B的参数
        /// 1 Galleon = 17 Sickle
        /// 1 Sickle = 29 Knut
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static string GetSunbtraction(string A, string B)
        {
            const int G_TO_S = 17;
            const int S_TO_K = 29;

            string[] listA = A.Split('.');
            string[] listB = B.Split('.');
            int G1 = ToInt(listA[0]); int S1 = ToInt(listA[1]); int K1 = ToInt(listA[2]);
            int G2 = ToInt(listB[0]); int S2 = ToInt(listB[1]); int K2 = ToInt(listB[2]);
            int G3 = 0; int S3 = 0; int K3 = 0;
            //Knut
            K3 = K1 - K2;
            if (K3 < 0)
            {
                K3 += S_TO_K;
                S1 -= 1;
            }
            //Sickle
            S3 = S1 - S2;
            if (S3 < 0)
            {
                S3 += G_TO_S;
                G1 -= 1;
            }
            //Galleon
            G3 = G1 - G2;

            return string.Format("{0}.{1}.{2}", G3, S3, K3);
        }

    }
}
