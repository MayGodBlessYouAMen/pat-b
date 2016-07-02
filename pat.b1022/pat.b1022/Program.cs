using System;
using System.Collections.Generic;

namespace pat.b1022
{
    /// <summary>
    /// 1022. D进制的A+B (20)
    /// PAT.b1022
    /// 2016.05.25
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

            //输入在一行中依次给出3个整数A、B和D。 
            //非负10进制整数A和B(<=2^30-1)   (1 < D <= 10)
            string[] args = Console.ReadLine().Split(' ');
            decimal A = decimal.Parse(args[0]);
            decimal B = decimal.Parse(args[1]);
            decimal D = decimal.Parse(args[2]);

            decimal C = A + B;

            if (C == 0)
            {
                Console.WriteLine(0);
                return;
            }

            List<int> list = new List<int>();
            while (C > 0)
            {
                decimal remainder = C % D;
                list.Add((int)remainder);
                C = Math.Truncate(C / D);
            }

            //float output = 0;
            //if (list.Count > 0)
            //{
            //    for (int i = list.Count - 1; i >= 0; i--)
            //    {
            //        output += (float)Math.Pow(10, i) * list[i];
            //    }
            //}

            ////输出A+B的D进制数。 
            //Console.WriteLine(Math.Truncate(output));

            string output = "";
            if (list.Count > 0)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    output += list[i].ToString();
                }
            }

            //输出A+B的D进制数。 
            Console.WriteLine(output);
        }
    }
}
