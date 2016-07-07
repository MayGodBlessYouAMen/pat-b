using System;

namespace pat.b1021
{
    /// <summary>
    /// PAT.1021
    /// 2016.05.10
    /// by XY
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Process();
            //}
            Process();
        }

        private static void Process()
        {
            //read input
            string input = Console.ReadLine().Trim();

            //change string to char[]
            char[] chars = input.ToCharArray();
            int[] count = new int[10];
            for (int i = 0; i < chars.Length; i++)
            {
                int j = int.Parse(chars[i].ToString());
                count[j]++;
            }

            //output
            for (int i = 0; i < 10; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0}:{1}", i, count[i]);
                }
            }
        }
    }
}