using System;

namespace pat.b1016
{
    /// <summary>
    /// 1016
    /// 2016.05.09 
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        { 
            string input = Console.ReadLine();

            string[] listInput = input.Trim().Split(' ');
            string A = listInput[0].Trim();
            string DA = listInput[1].Trim();
            string B = listInput[2].Trim();
            string DB = listInput[3].Trim();

            int countDA = A.Length - A.Replace(DA, "").Length;
            int countDB = B.Length - B.Replace(DB, "").Length;

            string PA = "";
            for (int i = 0; i < countDA; i++)
            {
                PA += DA;
            }
            if (string.IsNullOrEmpty(PA))
            {
                PA = "0";
            }

            string PB = "";
            for (int i = 0; i < countDB; i++)
            {
                PB += DB;
            }
            if (string.IsNullOrEmpty(PB))
            {
                PB = "0";
            }

            Console.WriteLine(Int64.Parse(PA) + Int64.Parse(PB));
        }
    }
}
