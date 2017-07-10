using System;
using System.Collections.Generic;
using System.Linq;

namespace pat.b1055
{
    /// <summary>
    /// 1055. 集体照 (25)
    /// pat.b1055
    /// 2016.06.09 
    /// by xy
    /// at osaki
    /// modify 2017.07.10
    /// at NingBo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            string[] args = Console.ReadLine().Split(' ');
            //总人数
            int N = int.Parse(args[0]);
            //行数
            int K = int.Parse(args[1]);

            int row = N;
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            List<Person> list = new List<Person>();
            while (row > 0)
            {
                string[] args1 = Console.ReadLine().Split(' ');
                //dic.Add(args1[0], int.Parse(args1[1]));
                Person p = new Person();
                p.Name = args1[0];
                p.Height = int.Parse(args1[1]);
                list.Add(p);
                row--;
            }

            //按身高降序，名字升序排序
            //IOrderedEnumerable<KeyValuePair<string, int>> orderKV = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key);  -->测试点4和5答案错误
            //list = list.OrderByDescending(x => x.Height).ThenBy(x => x.Name).ToList();  -->测试点4和5答案错误

            list.Sort((x, y) =>
            {
                if (x.Height != y.Height)
                {
                    //按身高降序
                    return -x.Height.CompareTo(y.Height);
                }
                else
                {
                    //身高相同，按名字升序
                    return x.Name.CompareTo(y.Name);
                }
            });  //-->测试点4和5答案错误

            //标准每排人数
            int m = N / K;
            //最后一排人数
            int n = m + N % K;

            List<string> listNames = new List<string>();
            //int count = 0;
            //foreach (KeyValuePair<string, int> kv in orderKV)
            //{
            //    DoInsert(kv.Key, listNames);

            //    if ((count + 1) == n ||
            //        (count + 1 > n && (count + 1 - n) % m == 0) ||
            //        count + 1  == N)
            //    {
            //        Console.WriteLine(string.Join(" ", listNames));
            //        listNames = new List<string>();
            //    }

            //    count++;
            //}

            for (int i = 0; i < list.Count; i++)
            {
                DoInsert(list[i].Name, listNames);

                if ((i + 1) == n ||
                    (i + 1 > n && (i + 1 - n) % m == 0) ||
                    i == list.Count - 1)
                {
                    Console.WriteLine(string.Join(" ", listNames));
                    listNames = new List<string>();
                }
            }
        }

        /*最高的最先插入，然后左右交替插入*/
        private static void DoInsert(string name, List<string> listNames)
        {
            if (listNames.Count == 0)
            {
                //直接插入
                listNames.Add(name);
            }
            else if (listNames.Count % 2 != 0)
            {
                //加到左边
                listNames.Insert(0, name);
            }
            else
            {
                //加到右边
                listNames.Add(name);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
}