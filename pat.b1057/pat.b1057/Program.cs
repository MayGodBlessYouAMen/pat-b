using System;

namespace pat.b1057
{
    /// <summary>
    /// pat.b1057 数零壹
    /// 2017.07.05
    /// by xy
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
            //输入转化为char数组
            char[] charArr = Console.ReadLine().ToCharArray();

            int sum = 0;

            //遍历char数组求和
            for (int i = 0; i < charArr.Length; i++)
            {
                //char可以和int计算
                if (charArr[i] >= 'a' && charArr[i] <= 'z')
                {
                    sum += charArr[i] - ('a' - 1);
                }
                else if (charArr[i] >= 'A' && charArr[i] <= 'Z')
                {
                    sum += charArr[i] - ('A' - 1);
                }
                else
                {
                    //do nothing
                }
            }

            /*  -->有一个测试点无法通过，原因未知。猜测转化为二进制方法有误
            //和转化为二进制字符串
            string binaryStr = Convert.ToString(sum, 2);

            //统计0和1个数(字符1替换为空格剩下的就是0，从而通过字符串长度计算0和1的个数)
            string zeroStr = binaryStr.Replace("1", "");
            string oneStr = binaryStr.Replace("0", "");

            Console.WriteLine(string.Format("{0} {1}", zeroStr.Length, oneStr.Length));
           */

            int zeroCount = 0;
            int oneCount = 0;
            while (sum > 0)
            {
                if (sum % 2 == 0)
                {
                    zeroCount++;
                }
                else
                {
                    oneCount++;
                }
                sum = sum / 2;
            }

            Console.WriteLine(string.Format("{0} {1}", zeroCount, oneCount));
        }
    }
}
