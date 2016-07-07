using System;

namespace PAT.b1002
{
    /*
     * pat.b1002
     * 2016.04.10 pm 23:20
     * by xy
     * at warabi
     */
    public class Program
    {
        private static string[] numberArray = new string[] { "ling", "yi", "er", "san", "si", "wu", "liu", "qi", "ba", "jiu" };

        public static void Main(string[] args)
        {
            //自然数n小于10的100次方。所以n不能用数字变量存储，应该用字符数组记录。
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input.Trim()))
            {
                Console.WriteLine("输入不能为空，请重新输入。");
                return;
            }

            char[] charArray = input.ToCharArray();

            if (charArray.Length > 100)
            {
                Console.WriteLine("输入自然数不能超过100位，请重新输入。");
                return;
            }

            int sum = 0;
            int n = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                bool ret = int.TryParse(charArray[i].ToString(), out n);
                if (!ret)
                {
                    Console.WriteLine("输入不是自然数，请重新输入");
                    return;
                }
                sum += n;
            }

            char[] sumArray = sum.ToString().ToCharArray();
            string output = "";
            for (int i = 0; i < sumArray.Length; i++)
            {
                if (i > 0)
                {
                    output += " ";
                }
                //注：(int)sumArray[i]会得到sumArray[i]的ascii码值，是错误的。
                output += numberArray[int.Parse(sumArray[i].ToString())];
            }

            Console.WriteLine(output);
        }
    }
}
