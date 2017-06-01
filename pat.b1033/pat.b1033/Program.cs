using System;
using System.Collections.Generic;
using System.Linq;

namespace pat.b1033
{
    /// <summary>
    /// PAT.b.1033
    /// 2017.06.01 add
    /// by XY
    /// at NingBo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            //可用字符：a-z  A-Z  0-9  _  ,  .  -  +

            //先读入两行
            char[] brokenArray = Console.ReadLine().ToCharArray();
            char[] inputArray = Console.ReadLine().ToCharArray();

            //判断上档键
            bool canOutputUpper = true;
            if (brokenArray.Contains('+'))
            {
                canOutputUpper = false;
            }

            //定义输出数组
            List<char> outputList = new List<char>();

            //遍历输入数组
            for (int i = 0; i < inputArray.Length; i++)
            {
                char item = inputArray[i];

                //上档键坏掉时，所有大写字母不能输出
                if (item>='A' && item<='Z' && !canOutputUpper)
                {
                    continue;
                }

                //坏掉的字母不能输出(小坑：如果是英文字母，对应的大小写都不能输出)
                if (brokenArray.Contains(Char.ToUpper(item)) || brokenArray.Contains(Char.ToLower(item)))
                {
                    continue;
                }

                //正常的字母添加到list
                outputList.Add(item);
            }

            Console.WriteLine(new string(outputList.ToArray()));
            //Console.ReadKey();
        }
    }
}
