using System;

namespace PAT.b1006
{
    /// <summary>
    /// pat.b1006
    /// 2016.04.13 0:22
    /// by xy
    /// at warabi
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input.Trim()))
            {
                Console.WriteLine("输入不能为空，请重新输入。");
                return;
            }

            int n = 0;
            bool ret = int.TryParse(input, out n);
            if (!ret)
            {
                Console.WriteLine("输入的不是整数，请重新输入。");
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("输入的数字不能小于1，请重新输入");
                return;
            }
            if (n >= 1000)
            {
                Console.WriteLine("输入的数字不能大于1000，请重新输入");
                return;
            }

            int hundreds = 0;//百位
            int tens = 0; //十位
            int bits = 0; //个位
            string output = ""; //输出用

            hundreds = n / 100;
            n = n % 100;

            tens = n / 10;
            n = n % 10;

            bits = n / 1;

            if (hundreds > 0)
            {
                for (int i = 0; i < hundreds; i++)
                {
                    output += "B";
                }
            }

            if (tens > 0)
            {
                for (int i = 0; i < tens; i++)
                {
                    output += "S";
                }
            }

            if (bits > 0)
            {
                for (int i = 0; i < bits; i++)
                {
                    output += (i + 1).ToString();
                }
            }

            Console.WriteLine(output);
        }
    }
}