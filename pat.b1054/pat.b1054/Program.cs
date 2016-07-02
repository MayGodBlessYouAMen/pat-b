using System;
using System.Collections.Generic;

namespace pat.b1054
{
    class Program
    {
        /// <summary>
        /// PAT.1054
        /// 2016.05.10 add
        /// 2016.06.23 modify
        /// by XY
        /// at osaki
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            process();
        }

        private static void process()
        {
            //read input
            string input1 = Console.ReadLine();
            string inputline2 = Console.ReadLine();

            //data process
            int n = int.Parse(input1);
            string[] inputlist2 = inputline2.Split(' ');
            List<string> legitimateList = new List<string>();
            List<string> illegalList = new List<string>();

            //check
            for (int i = 0; i < n; i++)
            {
                string temp = inputlist2[i];
                if (IsLegitimate(temp))
                {
                    legitimateList.Add(temp);
                }
                else
                {
                    illegalList.Add(temp);
                }
            }

            //calculate
            int legitimateCount = legitimateList.Count;
            decimal legitimateAverage = 0;
            string average = "";
            decimal legitimateSum = 0;
            if (legitimateCount > 0)
            {
                for (int i = 0; i < legitimateCount; i++)
                {
                    legitimateSum += decimal.Parse(legitimateList[i]);
                }

                legitimateAverage = Math.Round(legitimateSum / legitimateCount, 2, MidpointRounding.AwayFromZero);
                average = legitimateAverage.ToString("#0.00");  //精确到小数点后2位
            }

            //output
            for (int i = 0; i < illegalList.Count; i++)
            {
                Console.WriteLine("ERROR: {0} is not a legal number", illegalList[i]);
            }

            if (legitimateCount == 0)
            {
                Console.WriteLine("The average of 0 numbers is Undefined");
            }
            else if (legitimateCount == 1)
            {
                Console.WriteLine("The average of 1 number is {0}", average);
            }
            else
            {
                Console.WriteLine("The average of {0} numbers is {1}", legitimateCount, average);
            }

        }

        /// <summary>
        /// 数字合法验证 
        /// 一个“合法”的输入是[-1000，1000]区间内的实数，并且最多精确到小数点后2位。
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        private static bool IsLegitimate(string temp)
        {
            try
            {
                decimal result = 0;

                //判断是否是数字
                bool isNum = decimal.TryParse(temp, out result);
                if (!isNum)
                {
                    return false;
                }

                //判断大小范围
                if (result > 1000 || result < -1000)
                {
                    return false;
                }

                //判断小数是否超过2位 
                string[] list = temp.Split('.');
                if (list.Length >= 2 && list[1].Length > 2)
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
