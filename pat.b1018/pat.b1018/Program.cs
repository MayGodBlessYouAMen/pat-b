using System;

namespace pat.b1018
{
    /// <summary>
    /// 1018. 锤子剪刀布 (20)
    /// pat.b1018
    /// 2016.06.06
    /// 2016.06.23 modify
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
            int n = int.Parse(Console.ReadLine());

            int iVictory = 0; int iDefeat = 0; int iEqual = 0;

            int b1 = 0; int c1 = 0; int j1 = 0;
            int b2 = 0; int c2 = 0; int j2 = 0;

            int m = n;
            while (m > 0)
            {
                m--;

                string p1p2 = Console.ReadLine();
                if (p1p2 == "C J")
                {
                    c1++;
                }
                else if (p1p2 == "J B")
                {
                    j1++;
                }
                else if (p1p2 == "B C")
                {
                    b1++;
                }
                else if (p1p2 == "J C")
                {
                    c2++;
                }
                else if (p1p2 == "B J")
                {
                    j2++;
                }
                else if (p1p2 == "C B")
                {
                    b2++;
                }
                else
                {
                    iEqual++;
                }
            }

            iVictory = c1 + j1 + b1;
            iDefeat = n - iVictory - iEqual;

            Console.WriteLine(string.Format("{0} {1} {2}", iVictory, iEqual, iDefeat));
            Console.WriteLine(string.Format("{0} {1} {2}", iDefeat, iEqual, iVictory));

            string str1 = "";
            if (b1 >= c1 && b1 >= j1)
            {
                str1 = "B";
            }
            else if (c1 > b1 && c1 >= j1)
            {
                str1 = "C";
            }
            else if (j1 > b1 && j1 > c1)
            {
                str1 = "J";
            }

            string str2 = "";
            if (b2 >= c2 && b2 >= j2)
            {
                str2 += "B";
            }
            else if (c2 > b2 && c2 >= j2)
            {
                str2 += "C";
            }
            else if (j2 > b2 && j2 > c2)
            {
                str2 += "J";
            }
            Console.WriteLine("{0} {1}", str1, str2);
        }

    }
}
