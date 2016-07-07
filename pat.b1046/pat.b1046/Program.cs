using System;

namespace pat.b1046
{
    /// <summary>
    /// PAT.1046
    /// 2016.05.10
    /// by XY
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
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int adrink = 0;
            int bdrink = 0;
            while (n > 0)
            {
                string inputline = Console.ReadLine();
                string[] inputlist = inputline.Split(' ');
                int acall = int.Parse(inputlist[0]);
                int adraw = int.Parse(inputlist[1]);
                int bcall = int.Parse(inputlist[2]);
                int bdraw = int.Parse(inputlist[3]);

                //a drink
                if (adraw != (acall + bcall) && bdraw == (acall + bcall))
                {
                    adrink++;         // 输家罚一杯酒 
                }
                //b drink
                if (adraw == (acall + bcall) && bdraw != (acall + bcall))
                {
                    bdrink++;         // 输家罚一杯酒
                }

                n--;
            }
            Console.WriteLine("{0} {1}", adrink, bdrink);
        }
    }
}