using System;
using System.Collections.Generic;

namespace pat.b1043
{
    /// <summary>
    /// PAT.1043
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
            //template:PATest
            string input = Console.ReadLine().Trim();

            char[] chars = input.ToCharArray();
            int[] count = new int[6];
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'P':
                        count[0]++;
                        break;
                    case 'A':
                        count[1]++;
                        break;
                    case 'T':
                        count[2]++;
                        break;
                    case 'e':
                        count[3]++;
                        break;
                    case 's':
                        count[4]++;
                        break;
                    case 't':
                        count[5]++;
                        break;
                    default:
                        break;
                }
            }
            int maxCount = 0;
            for (int i = 0; i < 6; i++)
            {
                if (count[i] > maxCount)
                {
                    maxCount = count[i];
                }
            }
            List<char> charlist = new List<char>();
            string template = "PATest";
            char[] templatechars = template.ToCharArray();
            for (int i = 0; i < maxCount; i++)
            {
                for (int j = 0; j < templatechars.Length; j++)
                {
                    if (count[j] > 0)
                    {
                        charlist.Add(templatechars[j]);
                        count[j]--;
                    }
                }
            }
            Console.WriteLine(new string(charlist.ToArray()));
        }
    }
}
