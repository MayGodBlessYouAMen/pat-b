using System;

namespace pat.b1008
{
    class Program
    {
        /// <summary>
        /// PAT.1008
        /// 2016.05.10
        /// by XY
        /// at osaki
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //read input
            string inputline1 = Console.ReadLine();
            string inputline2 = Console.ReadLine();

            string[] inputlist1 = inputline1.Split(' ');
            string[] inputlist2 = inputline2.Split(' ');

            int n = int.Parse(inputlist1[0]);
            int m = int.Parse(inputlist1[1]);

            //每次移动1位,移动m次 
            for (int i = 0; i < m; i++)
            {
                string temp = inputlist2[n - 1];
                for (int j = n - 1; j >= 1; j--)
                {
                    inputlist2[j] = inputlist2[j - 1];
                }
                inputlist2[0] = temp;
            }

            //output
            string output = "";
            for (int i = 0; i < n; i++)
            {
                output += inputlist2[i] + " ";
            }
            output = output.TrimEnd();
            Console.WriteLine(output);

        }
    }
}
