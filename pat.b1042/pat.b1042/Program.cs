using System;

namespace pat.b1042
{
    /// <summary>
    /// PAT.1042
    /// 2016.05.10
    /// by XY
    /// at osaki
    /// key:ASCII码表有128个char字符,利用char和int之间的转换
    /// a:97 z:122 A:65 Z:90
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            string input = Console.ReadLine().ToLower();

            char[] inputchars = input.ToCharArray();
            int[] count = new int[128];
            for (int i = 0; i < inputchars.Length; i++)
            {
                if (inputchars[i] >= 97 && inputchars[i] <= 122)
                {
                    count[inputchars[i]]++;
                }
            }
            char output = ' ';
            int maxCount = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > maxCount)
                {
                    maxCount = count[i];
                    output = (char)i;
                }
            }
            Console.WriteLine("{0} {1}", output, maxCount);
        }
    }
}
