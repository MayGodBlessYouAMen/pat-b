using System;

namespace pat.b1029
{
    class Program
    {
        /// <summary>
        /// 1029. 旧键盘(20)
        /// pat.b1029
        /// 2016.06.03
        /// by xy
        /// at osaki
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            char[] listExpectt = Console.ReadLine().ToUpper().ToCharArray();
            char[] listActual = Console.ReadLine().ToUpper().ToCharArray();
            string str = "";

            //int[] except = new int[128];
            //for (int i = 0; i < listExpectt.Length; i++)
            //{
            //    except[listExpectt[i]]++;
            //}
            int[] actual = new int[128];
            for (int i = 0; i < listActual.Length; i++)
            {
                actual[listActual[i]]++;
            }

            //for (int i = 0; i < 128; i++)
            //{
            //    if (except[i] != 0 && actual[i] == 0)
            //    {
            //        str += ((char)i).ToString().ToUpper();
            //    }
            //}

            for (int i = 0; i < listExpectt.Length; i++)
            {
                if (actual[listExpectt[i]] == 0)
                {
                    if (!str.Contains(listExpectt[i].ToString()))
                    {
                        str += listExpectt[i].ToString();
                    }
                }
            }

            Console.WriteLine(str);
        }
    }
}
