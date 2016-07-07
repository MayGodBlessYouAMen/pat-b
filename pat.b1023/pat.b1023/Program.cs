using System;

namespace pat.b1023
{
    /// <summary>
    /// PAT.1023
    /// 2016.05.10
    /// by XY
    /// at warabi
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
            string[] inputlist = input.Split(' ');
            int[] count = new int[10];
            for (int i = 0; i < inputlist.Length; i++)
            {
                count[i] = int.Parse(inputlist[i]);
            }

            string output = "";
            if (count[0] > 0)
            {
                int first = 0;
                for (int i = 1; i < 10; i++)
                {
                    if (count[i] > 0)
                    {
                        output += i;
                        count[i]--;
                        first = i;
                        break;
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        output += i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        output += i;
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}