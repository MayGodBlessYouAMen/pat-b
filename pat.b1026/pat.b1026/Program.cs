using System;

namespace pat.b1026
{
    class Program
    {
        /// <summary>
        /// 1026. 程序运行时间(15)
        /// PAT.b1026
        /// 2016.05.25
        /// by xy
        /// at osaki
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            const int CLK_TCK = 100;

            string[] args = Console.ReadLine().Split(' ');

            int C1 = int.Parse(args[0]);
            int C2 = int.Parse(args[1]);

            int seconds = (int)Math.Round(Convert.ToDouble(C2 - C1) / CLK_TCK, MidpointRounding.AwayFromZero);

            Console.WriteLine(TimeFormat(seconds));
        }

        private static string TimeFormat(int seconds)
        {

            string ss = numFormat(seconds % 60);
            seconds = seconds / 60;
            string mm = numFormat(seconds % 60);
            string hh = numFormat(seconds / 60);

            return string.Format("{0}:{1}:{2}", hh, mm, ss);
        }

        private static string numFormat(int p)
        {
            if (p < 10)
            {
                return string.Format("0{0}", p);
            }
            else
            {
                return string.Format("{0}", p);
            }
        }
    }
}