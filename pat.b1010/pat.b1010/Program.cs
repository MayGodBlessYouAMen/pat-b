using System;

class Program
{
    /// <summary>
    /// pat.b1010
    /// 2016.07.03
    /// by xy
    /// at warabi
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
        for (int i = 0; i < args.Length / 2; i++)
        {
            int a1 = int.Parse(args[i * 2]);
            int a2 = int.Parse(args[i * 2 + 1]);

            if (a1 == 0 || a2 == 0)
            {
                break;
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
