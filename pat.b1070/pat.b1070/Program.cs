using System;

namespace pat.b1070
{
    /// <summary>
    /// pat.b1070. 结绳(25)
    /// 2017.07.10
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
            #region 思路
            /*
             *先排序，然后
             *
             *s1=a1
             *s2=(s1+a2)/2
             *...
             *sn=(s(n-1)+an)/2
             *
             *可以用递归
             */
            #endregion

            int n = int.Parse(Console.ReadLine());
            string[] strArray = Console.ReadLine().Split(' ');
            //转为int数组
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(strArray[i]);
            }
            //排序
            Array.Sort(intArray);
            //计算
            //因为向下取整。所以计算中的小数位其实可以忽略，故直接用int计算
            int s = F(intArray.Length, intArray);

            Console.WriteLine(s);
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="i">i的范围为1~intArray.Length</param>
        /// <param name="intArray"></param>
        /// <returns></returns>
        private static int F(int i, int[] intArray)
        {
            if (i == 1)
            {
                return intArray[i - 1];
            }
            else
            {
                return (F(i - 1, intArray) + intArray[i - 1]) / 2;
            }
        }

    }
}
