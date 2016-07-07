using System;

namespace PAT.b1001
{
    /*
     *2016.04.10 pm 22:20
     *注意点：这个不要写while循环输入 ，会报超时错误
     */
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input.Trim()))
            {
                Console.WriteLine("输入不能为空，请重新输入。");
                return;
            }

            int n = 0;
            bool ret = int.TryParse(input, out n);
            if (!ret)
            {
                Console.WriteLine("输入的不是整数，请重新输入。");
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("输入的数字不能小于1，请重新输入");
                return;
            }
            if (n > 1000)
            {
                Console.WriteLine("输入的数字不能大于1000，请重新输入");
                return;
            }

            int count = 0;
            if (n == 1)
            {
                count = 0;
            }
            else
            {
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        //如果它是偶数，那么把它砍掉一半
                        n /= 2;
                    }
                    else
                    {
                        //如果它是奇数，那么把(3n+1)砍掉一半
                        n = (3 * n + 1) / 2;
                    }
                    count++;
                }
            }

            if (n == 1)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("{0}计算没有得到1", n);
            }
        }
    }
}
