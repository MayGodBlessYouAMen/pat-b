using System;
using System.Collections.Generic;
using System.Linq;

namespace pat.b1014
{
    /// <summary>
    /// 1014. 福尔摩斯的约会 (20)
    /// PAT.b1014
    /// 2016.06.01
    /// by xy
    /// at osaki
    /// key:A(65)~Z(90) 
    /// 坑:两个字符串并不是循环两次匹配，而是相同index上字符比较。。。
    /// AC：2017.07.05
    /// </summary>
    class Program
    {
        static string[] Days = new string[] { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };

        static void Main(string[] args)
        {
            Process();
        }

        //ABCDEFGHIJKLMNOPQRSTUVWXYZ
        //abcdefghijklmnopqrstuvwxyz
        private static void Process()
        {
            List<char> list1 = Console.ReadLine().ToCharArray().ToList<char>();
            List<char> list2 = Console.ReadLine().ToCharArray().ToList<char>();
            List<char> list3 = Console.ReadLine().ToCharArray().ToList<char>();
            List<char> list4 = Console.ReadLine().ToCharArray().ToList<char>();

            //遍历比较第一个和第二个字符串
            char c1 = ' ';
            char c2 = ' ';
            int count = 0;
            for (int i = 0; i < (list1.Count > list2.Count ? list2.Count : list1.Count); i++)
            {
                if (list1[i].Equals(list2[i]))
                {

                    //第1对相同的大写英文字母(A~Z)
                    //注：一周只有七天，所以实际上是A~G? -->猜想正确
                    if (count == 0)
                    {
                        //if (list1[i] >= 'A' && list1[i] <= 'Z')
                        if (list1[i] >= 'A' && list1[i] <= 'G')
                        {
                            c1 = list2[i];
                            count++;
                        }
                        continue;
                    }

                    //第2对相同的字符  0~9 A~N
                    if (count == 1)
                    {
                        if ((list1[i] >= '0' && list1[i] <= '9') ||
                            (list1[i] >= 'A' && list1[i] <= 'N'))
                        {
                            c2 = list2[i];
                            break;
                        }
                        continue;
                    }
                }
            }

            //遍历比较第三第四个字符串，寻找第1对相同的英文字母位置
            int index = -1;
            for (int i = 0; i < (list3.Count > list4.Count ? list4.Count : list3.Count); i++)
            {
                if (list3[i].Equals(list4[i]) &&
                    ((list3[i] >= 'A' && list3[i] <= 'Z') || (list3[i] >= 'a' && list3[i] <= 'z')))
                {
                    index = i;
                    break;
                }
            }

            //ascll :'A'-->65  '0'-->48

            //day
            string day = Days[c1 - 65];

            //HH  
            string hour = "";
            if (c2 >= '0' && c2 <= '9')
            {
                hour = (c2 - 48).ToString("00");
            }
            else if (c2 >= 'A' && c2 <= 'N')
            {
                hour = (c2 - 65 + 10).ToString("00");
            }

            //MM
            string minute = index.ToString("00");

            //output
            Console.Write(string.Format("{0} {1}:{2}", day, hour, minute));

        }
    }
}