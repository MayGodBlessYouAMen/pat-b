using System;
using System.Collections.Generic;

namespace pat.b1003
{
    /// <summary>
    /// 1003. 我要通过！(20)
    /// PAT.B1003
    /// 2016.05.31
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
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            while (n > 0)
            {
                n--;
                list.Add(Console.ReadLine());
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (IsVailded(list[i]))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static bool IsVailded(string str)
        {
            //1.字符串中必须仅有P, A, T这三种字符，不可以包含其它字符;P, T有且仅有一个
            if (str.Replace("P", "").Replace("A", "").Replace("T", "") != "")
            {
                return false;
            }
            if (str.IndexOf("P") == -1 || str.IndexOf("A") == -1 || str.IndexOf("T") == -1)
            {
                return false;
            }
            if (str.IndexOf("P") != str.IndexOf("P") || str.IndexOf("T") != str.IndexOf("T"))
            {
                return false;
            }

            //2.任意形如 xPATx 的字符串都可以获得“答案正确”，其中 x 或者是空字符串，或者是仅由字母 A 组成的字符串
            //3. 如果 aPbTc 是正确的，那么 aPbATca 也是正确的，其中 a, b, c 均或者是空字符串，或者是仅由字母 A 组成的字符串。

            //综合2，3可得字符串的格式: (n个A)+P+(m个A)+T+(n*m个A)，n>=0,m>=1

            string[] args1 = str.Split('P');
            if (args1.Length != 2)
            {
                return false;
            }
            string[] args2 = args1[1].Split('T');
            if (args2.Length != 2)
            {
                return false;
            }
            string StrA1 = args1[0];
            string StrA2 = args2[0];
            string StrA3 = args2[1];
            if (StrA2.Length <= 0)
            {
                return false;
            }
            if (StrA3.Length != StrA1.Length * StrA2.Length)
            {
                return false;
            }

            return true;
        }
    }
}
