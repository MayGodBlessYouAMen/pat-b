using System;
using System.Text;
using System.Collections.Generic;

namespace pat.b1045
{
    /// <summary>
    /// 1045. 快速排序(25)
    /// pat.b1045
    /// 2016.06.01
    /// by xy
    /// at osaki
    /// update:2017.07.08
    /// at NingBo
    /// key:最后一段string拼接改为StringBuilder的append之后，不再超时
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] args = Console.ReadLine().Split(' ');  //空格分隔的N个不同的正整数，每个数不超过10^9
            List<Int32> list = new List<int>();
            for (int i = 0; i < args.Length; i++)
            {
                list.Add(Int32.Parse(args[i]));
            }

            int leftMax = 0;
            int[] leftFlagList = new int[list.Count];      //0:not valid  1:valid
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    leftFlagList[i] = 1;
                    leftMax = list[i];
                    continue;
                }
                if (i == list.Count - 1)
                {
                    if (list[i] > leftMax)
                    {
                        leftFlagList[i] = 1;
                    }
                    break;
                }

                if (list[i] > leftMax)
                {
                    leftFlagList[i] = 1;
                }

                if (leftMax < list[i])
                {
                    leftMax = list[i];
                }
            }


            int rightMin = 0;
            int[] rightFlagList = new int[list.Count];
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i == list.Count - 1)
                {
                    rightFlagList[i] = 1;
                    rightMin = list[i];
                    continue;
                }

                if (i == 0)
                {
                    if (list[i] < rightMin)
                    {
                        rightFlagList[i] = 1;
                    }
                    break;
                }

                if (list[i] < rightMin)
                {
                    rightFlagList[i] = 1;
                }

                if (rightMin > list[i])
                {
                    rightMin = list[i];
                }
            }

            //out
            int count = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (leftFlagList[i] == 1 && rightFlagList[i] == 1)
                {
                    if (count > 0)
                    {
                        sb.Append(" ");
                    }
                    sb.Append(list[i]);
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sb.ToString());

        }
    }
}