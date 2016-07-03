using System;

namespace pat.b1028
{
    /// <summary> 
    /// b.1028. 人口普查(20)
    /// 2016.05.22
    /// by xy
    /// at warabi
    /// </summary>
    class Program
    {
        const int YEAR1 = 1814;
        const int YEAR2 = 2014;
        const int MONTH = 9;
        const int DAY = 6;

        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Person oldest = new Person(YEAR2, MONTH, DAY);   //初始化为最小值
            Person youngest = new Person(YEAR1, MONTH, DAY); //初始化为最大值

            while (n > 0)
            {
                n--;

                string[] args = Console.ReadLine().Split(' ');
                string name = args[0];
                string date = args[1];

                if (IsValided(date))
                {
                    count++;

                    string[] args2 = date.Split('/');
                    int year = int.Parse(args2[0]);
                    int month = int.Parse(args2[1]);
                    int day = int.Parse(args2[2]);

                    if (year < oldest.year ||
                       (year == oldest.year && month < oldest.month) ||
                       (year == oldest.year && month == oldest.month && day < oldest.day))
                    {
                        oldest.name = name;
                        oldest.year = year;
                        oldest.month = month;
                        oldest.day = day;
                    }

                    if (year > youngest.year ||
                       (year == youngest.year && month > youngest.month) ||
                       (year == youngest.year && month == youngest.month && day > youngest.day))
                    {
                        youngest.name = name;
                        youngest.year = year;
                        youngest.month = month;
                        youngest.day = day;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(string.Format("{0} {1} {2}", count, oldest.name, youngest.name));
            }

        }

        /// <summary>
        /// check yyyy/mm/dd
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static bool IsValided(string date)
        {
            string[] args = date.Split('/');
            int year = int.Parse(args[0]);
            int month = int.Parse(args[1]);
            int day = int.Parse(args[2]);

            if (year < YEAR1 ||
               (year == YEAR1 && month < MONTH) ||
               (year == YEAR1 && month == MONTH && day < DAY))
            {
                return false;
            }

            if (year > YEAR2 ||
               (year == YEAR2 && month > MONTH) ||
               (year == YEAR2 && month == MONTH && day > DAY))
            {
                return false;
            }

            return true;
        }
    }

    class Person
    {
        public string name { set; get; }
        public int year { set; get; }
        public int month { set; get; }
        public int day { set; get; }

        public Person(int year, int month, int day)
        {
            this.name = "";
            this.year = year;
            this.month = month;
            this.day = day;
        }

    }
}
