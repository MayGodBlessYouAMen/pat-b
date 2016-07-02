using System;
using System.Collections.Generic;

namespace pat.b1041
{
    /// <summary>
    /// 1041. 考试座位号(15)
    /// pat.b1041
    /// 2016.06.03
    /// by xy
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
            int n = int.Parse(Console.ReadLine());  //read : “准考证号 试机座位号 考试座位号”
            Dictionary<string, string> studentDic = new Dictionary<string, string>();
            while (n > 0)
            {
                n--;
                string[] args = Console.ReadLine().Split(' ');
                studentDic.Add(args[1], args[0] + " " + args[2]);   //“试机座位号 准考证号+空格+考试座位号”
            }
            int m = int.Parse(Console.ReadLine());
            string[] args2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(studentDic[args2[i]]);   //“准考证号+空格+考试座位号”
            }
        }
    }
}
