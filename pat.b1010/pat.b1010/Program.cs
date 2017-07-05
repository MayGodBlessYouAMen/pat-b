using System;

class Program
{
    /// <summary>
    /// pat.b1010
    /// 2016.07.03
    /// by xy
    /// at warabi
    /// 返回非零 无解
    /// </summary>
    /// <returns></returns>
    static void Main()
    {
        Process();
    }

    private static void Process()
    {
        string[] args = Console.ReadLine().Split(' ');
        string output = "";
        int count = 0;
        int a1 = 0, a2 = 0;
        //以指数递降方式输入多项式 非零项 系数和指数
        for (int i = 0; i < args.Length / 2; i++)
        {
            a1 = int.Parse(args[i * 2]);
            a2 = int.Parse(args[i * 2 + 1]);

            //以与输入相同的格式输出导数多项式非零项的系数和指数。
            if (a1 == 0 || a2 == 0)
            {
                continue;
            }
            else
            {
                if (count > 0)
                {
                    output += " ";
                }
                output += string.Format("{0} {1}", a1 * a2, a2 - 1);
                count++;
            }
        }
        //注意“零多项式”的指数和系数都是0，但是表示为“0 0”。
        if (count == 0)
        {
            output = "0 0";
        }
        Console.WriteLine(output);
    }
}