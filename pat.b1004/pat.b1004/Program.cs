using System;

namespace pat.b1004
{
    /// <summary>
    /// PAT.b1004
    /// 2016.05.09
    /// XY osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string maxName = "";
                string maxNumber = "";
                int maxScore = 0;

                string minName = "";
                string minNumber = "";
                int minScore = 100;

                string input = Console.ReadLine();
                int n = int.Parse(input);
                while (n > 0)
                {
                    string inputLine = Console.ReadLine().Trim();

                    string[] listInput = inputLine.Split(' ');
                    string name = listInput[0];
                    string number = listInput[1];
                    int score = int.Parse(listInput[2]);

                    if (score > maxScore)
                    {
                        maxName = name;
                        maxNumber = number;
                        maxScore = score;
                    }

                    if (score < minScore)
                    {
                        minName = name;
                        minNumber = number;
                        minScore = score;
                    }

                    n--;
                }

                Console.WriteLine("{0} {1}", maxName, maxNumber);
                Console.WriteLine("{0} {1}", minName, minNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
