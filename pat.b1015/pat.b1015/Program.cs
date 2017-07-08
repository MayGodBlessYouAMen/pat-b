using System;
using System.Collections.Generic;
using System.Linq;

namespace pat.b1015
{
    /// <summary>
    /// 1015. 德才论 (25)
    /// pat.b1015
    /// 2016.06.03 
    /// by xy
    /// at osaki
    /// 难点：排序超时了。linq超时，List的sort超时,List的orderby超时
    /// 
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
            int n = int.Parse(args[0]);  //考生总数
            int L = int.Parse(args[1]);  //为录取最低分数线
            int H = int.Parse(args[2]);  //优先录取线
            List<Student> list1 = new List<Student>();
            List<Student> list2 = new List<Student>();
            List<Student> list3 = new List<Student>();
            List<Student> list4 = new List<Student>();
            while (n > 0)
            {
                n--;
                string[] args2 = Console.ReadLine().Split(' ');
                int No = int.Parse(args2[0]);
                int D = int.Parse(args2[1]);
                int C = int.Parse(args2[2]);
                Student student = new Student();
                student.No = No;
                student.D = D;
                student.C = C;
                student.DC = D + C;
                if (D >= H && C >= H)
                {
                    //才德全尽
                    list1.Add(student);
                }
                else if (D >= H && C >= L)
                {
                    //德胜才
                    list2.Add(student);
                }
                else if (D >= L && C >= L & D >= C)
                {
                    //“才德兼亡”但尚有“德胜才”
                    list3.Add(student);
                }
                else if (D >= L && C >= L)
                {
                    //达到最低线L的考生
                    list4.Add(student);
                }
                else
                {
                    //不合格
                    //do nothing
                }
            }

            //输出第1行首先给出达到最低分数线的考生人数M
            Console.WriteLine(list1.Count + list2.Count + list3.Count + list4.Count);

            //分类顺序打印
            Print(list1);
            Print(list2);
            Print(list3);
            Print(list4);
        }

        private static void Print(List<Student> list)
        {
            if (list.Count > 0)
            {
                //按总分排序(降序);总分相同时，按其德分降序排列;若德分也并列，则按准考证号的升序

                /*
                //linq超时
                IEnumerable<Student> sortQuery = from s in list
                                                 orderby s.DC descending, s.D descending, s.No
                                                 select s;

                foreach (Student s in sortQuery)
                {
                    Console.WriteLine(string.Format("{0} {1} {2}", s.No, s.D, s.C));
                }
                */

                /*
                //依旧超时
                list.Sort(delegate(Student x, Student y)
                {
                    if (x.DC != y.DC)
                    {
                        //总分降序
                        return -x.DC.CompareTo(y.DC);
                    }
                    else
                    {
                        if (x.D != y.D)
                        {
                            //德分降序
                            return -x.D.CompareTo(y.D);
                        }
                        else
                        {
                            //学号升序
                            return x.No.CompareTo(y.No);
                        }
                    }
                });
                */

                //lambda表达式的写法。与delegate相同。-->lambda稍微快一点点，多通过了1个测试点
                list.Sort((x, y) =>
                {
                    if (x.DC != y.DC)
                    {
                        //总分降序
                        return -x.DC.CompareTo(y.DC);
                    }
                    else
                    {
                        if (x.D != y.D)
                        {
                            //德分降序
                            return -x.D.CompareTo(y.D);
                        }
                        else
                        {
                            //学号升序
                            return x.No.CompareTo(y.No);
                        }
                    }
                });

                //尝试 list的orderby  -->超时
                //list = list.OrderByDescending(o => o.DC).ThenByDescending(o => o.D).ThenBy(o => o.No).ToList();

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(string.Format("{0} {1} {2}", list[i].No, list[i].D, list[i].C));
                }
            }
        }

        struct Student
        {
            /// <summary>
            /// 准考证号
            /// </summary>
            public int No { set; get; }
            /// <summary>
            /// 德分
            /// </summary>
            public int D { set; get; }
            /// <summary>
            /// 才分
            /// </summary>
            public int C { set; get; }
            /// <summary>
            /// 德才总分
            /// </summary>
            public int DC { set; get; }
        }
    }
}