using System;
using System.Text;

namespace pat.b1048
{
    /// <summary>
    /// 1048. 数字加密(20)
    /// PAT.b1048
    /// 2016.05.26 --> 答案错误
    /// 2016.06.24 modify
    /// by xy
    /// at osaki
    /// 2016.07.08 modify
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
            string[] args = Console.ReadLine().Split(' ');
            Char[] listA;
            Char[] listB;

            int lenA = args[0].Length;
            int lenB = args[1].Length;

            //将A和B稍短的那个，左端用0填补至两个长度相同
            //注:PadLeft的第一个参数是填充后字符串的总长度。不要错写为差的长度。
            if (lenA > lenB)
            {
                args[1] = args[1].PadLeft(lenA, '0');
            }
            else if (lenA < lenB)
            {
                args[0] = args[0].PadLeft(lenB, '0');
            }

            int n = args[0].Length;
            listA = args[0].ToCharArray();
            listB = args[1].ToCharArray();
            StringBuilder sboutput = new StringBuilder();

            //个位为第1位
            for (int i = n - 1; i >= 0; i--)
            {
                int m = 0;
                if ((n - i) % 2 != 0)
                {
                    m = (int.Parse(listB[i].ToString()) + int.Parse(listA[i].ToString())) % 13;  //奇数位
                }
                else
                {
                    m = int.Parse(listB[i].ToString()) - int.Parse(listA[i].ToString());  //偶数位
                }
                //新字符插入到最左边。
                sboutput.Insert(0, Format(m));
            }

            Console.WriteLine(sboutput.ToString());

        }

        private static string Format(int m)
        {
            if (m < 0)
            {
                m += 10;
            }

            if (m == 10)
            {
                return "J";
            }
            else if (m == 11)
            {
                return "Q";
            }
            else if (m == 12)
            {
                return "K";
            }
            else
            {
                return m.ToString();
            }
        }
    }
}