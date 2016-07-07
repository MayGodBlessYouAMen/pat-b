using System;

namespace pat.b1009
{
    /// <summary>
    /// PAT.1009
    /// 2016.05.09
    /// XY osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string input = Console.ReadLine();
                string[] listInput = input.Split(' ');
                string output = "";
                for (int i = listInput.Length - 1; i >= 0; i--)
                {
                    output += listInput[i];
                    if (i > 0)
                    {
                        output += " ";
                    }
                }
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
