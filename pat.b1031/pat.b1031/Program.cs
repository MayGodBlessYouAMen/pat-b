using System;
using System.Collections.Generic;

namespace pat.b1031
{
    /// <summary>
    /// 1031. 查验身份证(15)
    /// pat.b1031
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
            int N = int.Parse(Console.ReadLine());
            int n = N;
            List<string> errlist = new List<string>();
            while (n > 0)
            {
                n--;
                string str = Console.ReadLine();
                if (!IsValided(str))
                {
                    errlist.Add(str);
                }
            }

            if (errlist.Count == 0)
            {
                Console.WriteLine("All passed");
            }
            else
            {
                for (int i = 0; i < errlist.Count; i++)
                {
                    Console.WriteLine(errlist[i]);
                }
            }

        }

        private static bool IsValided(string str)
        {
            int[] weights = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            char[] mlist = new char[] { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };
            char[] list = str.ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                if (list[i] >= '0' && list[i] <= '9')
                {
                    sum += weights[i] * int.Parse(list[i].ToString());
                }
                else
                {
                    return false;
                }
            }
            int Z = sum % 11;
            if (mlist[Z] == list[17])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
