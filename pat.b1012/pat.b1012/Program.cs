using System;
using System.Collections.Generic;

namespace pat.b1012
{
    /// <summary>
    /// pat.b1012
    /// 2016.05.22
    /// by xy
    /// at warabi
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Prcess();
        }

        private static void Prcess()
        {
            string[] args = Console.ReadLine().Split(' ');
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list4 = new List<int>();
            List<int> list5 = new List<int>();

            int n = int.Parse(args[0]);

            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                int num = int.Parse(args[i]);
                int iRet = GetType(num);
                switch (iRet)
                {
                    case 1:
                        list1.Add(num);
                        break;
                    case 2:
                        list2.Add(num);
                        break;
                    case 3:
                        list3.Add(num);
                        break;
                    case 4:
                        list4.Add(num);
                        break;
                    case 5:
                        list5.Add(num);
                        break;
                    default:
                        break;
                }
            }

            string output = "";

            if (list1.Count <= 0)
            {
                output = "N";
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < list1.Count; i++)
                {
                    sum += list1[i];
                }
                output = sum.ToString();
            }

            if (list2.Count <= 0)
            {
                output += " N";
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < list2.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += list2[i];
                    }
                    else
                    {
                        sum -= list2[i];
                    }
                }
                output += " " + sum.ToString();
            }

            if (list3.Count <= 0)
            {
                output += " N";
            }
            else
            {
                output += " " + list3.Count.ToString();
            }

            if (list4.Count <= 0)
            {
                output += " N";
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < list4.Count; i++)
                {
                    sum += list4[i];
                }
                double avg = Math.Round((double)(sum * 1.00) / list4.Count, 1);
                output += " " + avg.ToString("0.0");
            }

            if (list5.Count <= 0)
            {
                output += " N";
            }
            else
            {
                int max = 0;
                for (int i = 0; i < list5.Count; i++)
                {
                    if (max < list5[i])
                    {
                        max = list5[i];
                    }
                }
                output += " " + max.ToString();
            }

            Console.WriteLine(output);
        }

        private static int GetType(int num)
        {
            if (num < 1)
            {
                return 0;
            }

            int a1 = num / 5;
            int a2 = num % 5;

            switch (a2)
            {
                case 0:
                    if (num % 2 == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case 1:
                    return 2;
                case 2:
                    return 3;
                case 3:
                    return 4;
                case 4:
                    return 5;
                default:
                    return 0;
            }
        }
    }
}