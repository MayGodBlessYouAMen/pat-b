using System;
using System.Collections.Generic;

namespace pat.b1011
{
    /// <summary>
    /// 1011. A+B和C (15)
    /// pat.b1011
    /// 2016.05.31
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
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            while (n > 0)
            {
                n--;
                list.Add(Console.ReadLine());
            }
            for (int i = 0; i < list.Count; i++)
            {
                string str = "";
                string[] args = list[i].Split(' ');
                //注:2^31要用int64
                if (Convert.ToInt64(args[0]) + Convert.ToInt64(args[1]) > Convert.ToInt64(args[2]))
                {
                    str = "true";
                }
                else
                {
                    str = "false";
                }
                Console.WriteLine(string.Format("Case #{0}: {1}", i + 1, str));
            }
        }
    }
}
