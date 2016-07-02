using System;
using System.Collections.Generic;
using System.Linq;

namespace pat.b1019
{
    /// <summary>
    /// 1019. 数字黑洞 (20)
    /// pat.b1019
    /// 2016.06.07
    /// by xy
    /// at osaki
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            string args = Console.ReadLine();
            args = int.Parse(args).ToString("0000");
            List<char> list = args.ToCharArray().ToList<char>();

            if (list[0] == list[1] && list[0] == list[2] && list[0] == list[3])
            {
                Console.WriteLine(string.Format("{0} - {0} = 0000", args));
                return;
            }

            string C = "";
            while (C != "6174")
            {
                List<char> list1 = new List<char>();
                List<char> list2 = new List<char>();

                #region 插入排序
                for (int i = 0; i < 4; i++)
                {

                    if (i == 0)
                    {
                        list1.Add(list[i]);
                        list2.Add(list[i]);
                    }
                    else
                    {
                        //1.降序
                        bool isFind1 = false;
                        for (int j = 0; j < list1.Count; j++)
                        {
                            //找到了，插入
                            if (list[i] >= list1[j])
                            {
                                list1.Insert(j, list[i]);
                                isFind1 = true;
                                break;
                            }
                        }
                        //没找到，末尾追加
                        if (!isFind1)
                        {
                            list1.Add(list[i]);
                        }

                        //2.升序
                        bool isFind2 = false;
                        for (int j = 0; j < list2.Count; j++)
                        {
                            //找到了，插入
                            if (list[i] <= list2[j])
                            {
                                list2.Insert(j, list[i]);
                                isFind2 = true;
                                break;
                            }

                        }
                        //没找到，末尾追加
                        if (!isFind2)
                        {
                            list2.Add(list[i]);
                        }
                    }
                }
                #endregion 插入排序

                string A = new string(list1.ToArray<char>());
                string B = new string(list2.ToArray<char>());
                C = (int.Parse(A) - int.Parse(B)).ToString("0000");  //每个数字按4位数格式
                list = C.ToList<char>();

                Console.WriteLine(string.Format("{0} - {1} = {2}", A, B, C));
            }
        }
    }
}
