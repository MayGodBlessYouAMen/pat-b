using System;
using System.Collections.Generic;
using System.Linq;

namespace pat.b1044
{
    /// <summary> 
    /// PAT.b1044
    /// 2016.05.18
    /// by XY
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Process();
            //}
            Process();
        }

        private static void Process()
        {
            try
            {
                string[] Keys1 = new string[] 
                { "tret", "jan", "feb", "mar", "apr", "may", "jun", "jly", "aug", "sep", "oct", "nov", "dec"
                }; //个位
                string[] Keys2 = new string[] 
                { 
                  "tam", "hel", "maa", "huh", "tou", "kes", "hei", "elo", "syy", "lok", "mer", "jou"
                }; //高位
                Dictionary<string, int> MarsNumber1 = new Dictionary<string, int>()
                {
                    {"tret",0},{"jan",1}, {"feb",2}, {"mar",3}, {"apr",4}, {"may",5}, {"jun",6}, {"jly",7}, {"aug",8}, {"sep",9}, {"oct",10}, {"nov",11}, {"dec",12}
                };//个位
                Dictionary<string, int> MarsNumber2 = new Dictionary<string, int>()
                { 
                    {"tam",1}, {"hel",2}, {"maa",3}, {"huh",4}, {"tou",5}, {"kes",6}, {"hei",7}, {"elo",8}, {"syy",9}, {"lok",10}, {"mer",11}, {"jou",12}
                }; //高位
                Dictionary<int, string> EarthNumber1 = new Dictionary<int, string>();  //个位
                for (int i = 0; i < MarsNumber1.Count; i++)
                {
                    EarthNumber1.Add(MarsNumber1[Keys1[i]], Keys1[i]);
                }
                Dictionary<int, string> EarthNumber2 = new Dictionary<int, string>();  //高位
                for (int i = 0; i < MarsNumber2.Count; i++)
                {
                    EarthNumber2.Add(MarsNumber2[Keys2[i]], Keys2[i]);
                }

                int n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    string input = Console.ReadLine();
                    int a = 0;
                    bool ret = int.TryParse(input, out a);
                    if (ret)
                    {
                        //change Earth to Mars
                        int a1 = 0; //个位
                        int a2 = 0; //高位
                        a1 = a % 13;
                        a2 = a / 13;

                        if (a2 != 0)
                        {
                            if (a1 == 0)
                            {
                                Console.WriteLine("{0}", EarthNumber2[a2]);  //ex: 13 is tam,not tam tret
                            }
                            else
                            {
                                Console.WriteLine("{0} {1}", EarthNumber2[a2], EarthNumber1[a1]);
                            }

                        }
                        else
                        {
                            Console.WriteLine("{0}", EarthNumber1[a1]);
                        }
                    }
                    else
                    {
                        //change Mars to Earth
                        string[] str = input.Split(' ');
                        int a1 = 0; //个位
                        int a2 = 0; //高位
                        if (str.Length == 1)
                        {
                            if (Keys1.Contains(str[0]))
                            {
                                a1 = MarsNumber1[str[0]];
                            }
                            else if (Keys2.Contains(str[0]))
                            {
                                a2 = MarsNumber2[str[0]];
                            }
                        }
                        else if (str.Length == 2)
                        {
                            a2 = MarsNumber2[str[0]];
                            a1 = MarsNumber1[str[1]];
                        }
                        else
                        {
                            //
                        }
                        Console.WriteLine(a2 * 13 + a1);
                    }

                    n--;
                } 
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
