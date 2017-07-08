using System;
using System.Text;

namespace pat.b1038
{
    /// <summary>
    /// 1038. 统计同成绩学生(20)
    /// pat.b1038 
    /// 2016.06.03
    /// by xy
    /// at osaki
    /// update:2017.07.08
    /// at NingBo
    /// keyword: 百分制整数成绩 0~100
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            //学生总人数
            int n = int.Parse(Console.ReadLine());

            //N名学生的百分制整数成绩
            string[] listActual = Console.ReadLine().Split(' ');

            //要查询的分数个数K和K个分数
            string[] listExpect = Console.ReadLine().Split(' ');

            //先遍历所有计数,统计每个分数的个数
            int[] score = new int[101];
            for (int i = 0; i < listActual.Length; i++)
            {
                score[int.Parse(listActual[i])]++;
            }

            //根据给的分数，匹配对应的人数
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < listExpect.Length; i++)
            {
                if (i > 1)
                {
                    sb.Append(" ");
                }
                sb.Append(score[int.Parse(listExpect[i])]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}