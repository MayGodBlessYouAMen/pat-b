using System;

namespace pat.b1053
{
    /// <summary> 
    /// PAT.1053
    /// 2016.05.18
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
            string[] args0 = Console.ReadLine().Split(' ');       //5 0.5 10

            int totalNumber = int.Parse(args0[0]);                //居民区住房总套数
            decimal lowPowerThreshold = decimal.Parse(args0[1]);  //低电量阈值
            int dayThreshold = int.Parse(args0[2]);               //观察期阈值

            int maybeEmptyNumber = 0;
            int emptyNumber = 0;

            int n = totalNumber;
            while (n > 0)
            {
                n--;

                string[] args1 = Console.ReadLine().Split(' ');
                int watchDays = int.Parse(args1[0]);  //观察的天数

                int lowPowerDays = 0;
                for (int i = 1; i < args1.Length; i++)
                {
                    if (decimal.Parse(args1[i]) < lowPowerThreshold)
                    {
                        lowPowerDays++;  //低电量日数
                    }
                }

                //在观察期内，若存在超过一半的日子用电量低于某给定的阈值e，则该住房为“可能空置” 
                //若观察期超过某给定阈值D天，且满足上一个条件，则该住房为“空置”
                if (lowPowerDays * 2 > watchDays)
                {
                    if (watchDays > dayThreshold)
                    {
                        emptyNumber++;
                    }
                    else
                    {
                        maybeEmptyNumber++;
                    }
                }
            }

            //输出“可能空置”的比率和“空置”比率的百分比值，其间以一个空格分隔，保留小数点后1位
            Console.WriteLine(string.Format("{0}% {1}%", Math.Round((decimal)maybeEmptyNumber * 100 / totalNumber, 1), Math.Round((decimal)emptyNumber * 100 / totalNumber, 1)));

        }
    }
}
