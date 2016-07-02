using System;

namespace pat.b1024
{
    /// <summary>
    /// 1024. 科学计数法 (20)
    /// PAT.b1024
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

        /* ex: +1.23400E-03
         * part1:+
         * part2:1
         * part3:23400        -->不超过9999位
         * part4:-
         * part5:03　　　　　 -->不超过9999
         */
        private static void Process()
        {
            string str = Console.ReadLine();
            string[] args1 = str.Split('.');
            string[] args2 = args1[1].Split('E');

            string part1 = args1[0].Substring(0, 1);
            string part2 = args1[0].Substring(1, 1);
            string part3 = args2[0];
            string part4 = args2[1].Substring(0, 1);
            string part5 = args2[1].Substring(1);

            int n = int.Parse(part5);

            string output = "";
            if (part1 == "-")
            {
                output += part1;
            }

            if (part4 == "-")
            {
                output += "0.";
                output += GetZero(n - 1);
                output += part2;   //add at 2016.06.03
                output += part3;
            }
            else if (part4 == "+")
            {
                output += part2;
                if (n >= part3.Length)
                {
                    output += part3;
                    output += GetZero(n - part3.Length);
                }
                else
                {
                    output += part3.Substring(0, n) + "." + part3.Substring(n);
                }
            }

            Console.WriteLine(output);
        }

        /// <summary>
        /// add at 2016.06.22
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string GetZero(int n)
        {
            if (n <= 0)
            {
                return "";
            }

            string str = "";
            string str100 = "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";

            int a = n / 100;
            int b = n % 100;

            for (int i = 0; i < a; i++)
            {
                str += str100;
            }

            for (int i = 0; i < b; i++)
            {
                str += "0";
            }

            return str;
        }
    }
}
