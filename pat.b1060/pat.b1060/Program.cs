using System;

namespace pat.b1060
{
    /// <summary>
    /// pat.b1060. 爱丁顿数(25)
    /// 2017.07.09
    /// by XY
    /// at NingBo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        /// <summary>
        /// 题目理解：给定数字N，从（至少1天超过1公里，至少2天超过2公里，...,至少E天超过E公里，...,至少N天超过N公里）中找到满足条件的最大E
        /// </summary>
        private static void Process()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            //转为int数组
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = int.Parse(arr[i]);
            }
            //排序
            Array.Sort(newArr);

            //设置为数组下标从1开始
            int e = 0;
            int j = 1;
            for (int i = 1; i <= newArr.Length; i++)
            {
                //寻找第一个大于i英里的
                while (j <= n)
                {
                    if (newArr[j - 1] <= i)
                    {
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }

                //比较（大于i英里的天数）和（i）的大小
                if (n - j + 1 >= i)
                {
                    e = i;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(e);
        }
    }
}
