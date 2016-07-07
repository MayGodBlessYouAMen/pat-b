using System;

namespace pat.b1036
{
    /// <summary>
    /// PAT.b1036
    /// 2016.05.10
    /// by XY 
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine().Trim();
                string[] listInput = input.Split(' ');
                int n = int.Parse(listInput[0]);
                string c = listInput[1];

                string headline = GetHeadLine(n, c);
                string bodyline = GetBodyLine(n, c);

                int rowcount = int.Parse((Math.Round((decimal)n / 2, MidpointRounding.AwayFromZero)).ToString());
                for (int i = 1; i <= rowcount; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine(headline);
                    }
                    else if (i < rowcount)
                    {
                        Console.WriteLine(bodyline);
                    }
                    else
                    {
                        Console.WriteLine(headline);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string GetHeadLine(int n, string c)
        {
            string line = "";
            for (int i = 0; i < n; i++)
            {
                line += c;
            }

            return line;
        }

        private static string GetBodyLine(int n, string c)
        {
            string line = "";
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    line += c;
                }
                else if (i < n - 1)
                {
                    line += " ";
                }
                else
                {
                    line += c;
                }
            }

            return line;
        }
    }
}