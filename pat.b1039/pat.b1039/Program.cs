using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pat.b1039
{
    /// <summary>
    /// 1039. 到底买不买（20）
    /// PAT.b1039
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

        /*
         * 遍历期望值，每次在目标中删除找到的第一个匹配字符，如果找到，同时删除期望值中的该位置字符
         * 最后剩下的数量做判断即可
         * 为了方便删除，期望值应该从后往前遍历
         */
        private static void Process()
        {
            List<Char> listActual = Console.ReadLine().ToCharArray().ToList<char>();
            List<Char> listExpect = Console.ReadLine().ToCharArray().ToList<char>();

            for (int i = listExpect.Count - 1; i >= 0; i--)
            {
                int matchIndex = listActual.FindIndex(x => x.Equals(listExpect[i]));
                if (matchIndex != -1)
                {
                    listActual.RemoveAt(matchIndex);
                    listExpect.RemoveAt(i);
                }
            }

            if (listExpect.Count == 0)
            {
                Console.WriteLine(string.Format("Yes {0}", listActual.Count - listExpect.Count));
            }
            else
            {
                Console.WriteLine(string.Format("No {0}", listExpect.Count));
            }
        }
    }
}
