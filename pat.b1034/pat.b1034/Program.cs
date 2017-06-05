using System;

namespace pat.b1034
{
    /// <summary>
    /// 1034. 有理数四则运算(20)
    /// PAT.b.1034
    /// 2017.06.01
    /// 2017.06.05 done
    /// 全部使用int计算，但是第三个测试点无法通过，猜测是整型计算超过范围，改成long-->依旧无法通过
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
            //输入
            string[] input = Console.ReadLine().Split(' ');

            //输出
            string a = Format(input[0]);
            string b = Format(input[1]);

            //输入的分数先自己约分
            input[0] = Format2(input[0]);
            input[1] = Format2(input[1]);

            //加
            Console.WriteLine(string.Format("{0} + {1} = {2}", a, b, Format(Add(input[0], input[1]))));
            //减
            Console.WriteLine(string.Format("{0} - {1} = {2}", a, b, Format(Sub(input[0], input[1]))));
            //乘
            Console.WriteLine(string.Format("{0} * {1} = {2}", a, b, Format(Mul(input[0], input[1]))));
            //除
            if ("0".Equals(b))
            {
                Console.WriteLine(string.Format("{0} / {1} = {2}", a, b, "Inf"));
            }
            else
            {
                Console.WriteLine(string.Format("{0} / {1} = {2}", a, b, Format(Div(input[0], input[1]))));
            }
        }

        //将分数计算出整数部分
        private static string Format(string exp)
        {
            string[] arr = exp.Split('/');
            long a = long.Parse(arr[0]) / long.Parse(arr[1]);
            long b = long.Parse(arr[0]) % long.Parse(arr[1]);

            if (a > 0)
            {
                if (b != 0)
                {
                    return string.Format("{0} {1}/{2}", a, b, arr[1]);
                }
                else
                {
                    return string.Format("{0}", a);
                }
            }

            if (a < 0)
            {
                if (b != 0)
                {
                    return string.Format("({0} {1}/{2})", a, b * (-1), arr[1]);
                }
                else
                {
                    return string.Format("({0})", a);
                }
            }

            if (a == 0)
            {
                //a为0时，b要判断符号
                if (b > 0)
                {
                    return string.Format("{0}/{1}", b, arr[1]);
                }
                else if (b == 0)
                {
                    return string.Format("{0}", b);
                }
                else
                {
                    return string.Format("({0}/{1})", b, arr[1]);
                }
            }

            return string.Empty;
        }

        //分数自己约分
        private static string Format2(string exp)
        {
            string[] arr = exp.Split('/');
            long a = long.Parse(arr[0]);
            long b = long.Parse(arr[1]);

            //最大公约数
            long max = GetMaxCommonDivisor(a, b);

            return string.Format("{0}/{1}", a / max, b / max);
        }

        //加
        private static string Add(string a, string b)
        {
            string[] arrA = a.Split('/');
            string[] arrB = b.Split('/');

            //最小公倍数
            long multi = GetMinCommonMultiple(long.Parse(arrA[1]), long.Parse(arrB[1]));

            return string.Format("{0}/{1}", long.Parse(arrA[0]) * (multi / long.Parse(arrA[1])) + long.Parse(arrB[0]) * (multi / long.Parse(arrB[1])), multi);
        }

        //减
        private static string Sub(string a, string b)
        {
            string[] arrA = a.Split('/');
            string[] arrB = b.Split('/');

            //最小公倍数
            long multi = GetMinCommonMultiple(long.Parse(arrA[1]), long.Parse(arrB[1]));

            return string.Format("{0}/{1}", long.Parse(arrA[0]) * (multi / long.Parse(arrA[1])) - long.Parse(arrB[0]) * (multi / long.Parse(arrB[1])), multi);
        }

        //乘
        private static string Mul(string a, string b)
        {
            string[] arrA = a.Split('/');
            string[] arrB = b.Split('/');

            //最大公约数
            long div1 = GetMaxCommonDivisor(long.Parse(arrA[0]), long.Parse(arrB[1]));
            long div2 = GetMaxCommonDivisor(long.Parse(arrA[1]), long.Parse(arrB[0]));

            return string.Format("{0}/{1}", (long.Parse(arrA[0]) / div1) * (long.Parse(arrB[0]) / div2), (long.Parse(arrA[1]) / div2) * (long.Parse(arrB[1]) / div1));
        }

        //除
        private static string Div(string a, string b)
        {
            string[] arrA = a.Split('/');
            string[] arrB = b.Split('/');

            //最大公约数
            long div1 = GetMaxCommonDivisor(long.Parse(arrA[0]), long.Parse(arrB[0]));
            long div2 = GetMaxCommonDivisor(long.Parse(arrA[1]), long.Parse(arrB[1]));

            //如果有负号，要放到分子上显示
            long b1 = long.Parse(arrB[0]);
            long b2 = long.Parse(arrB[1]);
            if (b1 < 0)
            {
                b1 *= -1;
                b2 *= -1;
            }
            return string.Format("{0}/{1}", (long.Parse(arrA[0]) / div1) * (b2 / div2), (long.Parse(arrA[1]) / div2) * (b1 / div1));
        }

        //求最大公约数
        private static long GetMaxCommonDivisor(long a, long b)
        {
            //辗转相除法
            long max = Math.Max(Math.Abs(a), Math.Abs(b));
            long min = Math.Min(Math.Abs(a), Math.Abs(b));
            while (min != 0)
            {
                max = max > min ? max : min;
                long temp = max % min;
                max = min;
                min = temp;
            }
            return max;
        }

        //求最小公倍数
        private static long GetMinCommonMultiple(long a, long b)
        {
            //最小公倍数=两个数的乘积除以这两个数最大公约数
            return (Math.Abs(a) * Math.Abs(b)) / GetMaxCommonDivisor(a, b);
        }
    }
}
