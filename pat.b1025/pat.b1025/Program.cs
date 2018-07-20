using System;
using System.Collections.Generic;

namespace pat.b1025
{
    /// <summary>
    /// 1025. 反转链表 (25)
    /// PAT.b1025
    /// 2018.07.20
    /// by xy
    /// at NingBo
    /// 超时
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        private static void Process()
        {
            //输入第一行
            string firststr = Console.ReadLine();
            string[] firstArgs = firststr.Split(' ');
            int firstAddress = int.Parse(firstArgs[0]);
            int totalCount = int.Parse(firstArgs[1]);
            int k = int.Parse(firstArgs[2]);

            Dictionary<int, int> dickeyValue = new Dictionary<int, int>();
            Dictionary<int, int> dicKeyNext = new Dictionary<int, int>();

            //输入明细
            int n = totalCount;
            while (n > 0)
            {
                string oneline = Console.ReadLine();
                string[] lineArr = oneline.Split(' ');
                dickeyValue.Add(int.Parse(lineArr[0]), int.Parse(lineArr[1]));
                dicKeyNext.Add(int.Parse(lineArr[0]), int.Parse(lineArr[2]));
                n--;
            }

            //按链表节点排序
            List<Node> listNodes = new List<Node>();  
            int key = firstAddress;
            while (key != -1)
            {
                Node node = new Node()
                {
                    Address = key,
                    Data = dickeyValue[key],
                    Next = dicKeyNext[key]
                };
                listNodes.Add(node);

                key = node.Next;

                //Console.WriteLine(string.Format("key={0} value={1} next={2}", node.Address, node.Data, node.Next));
            }

            //考虑到可能有孤立节点
            totalCount = listNodes.Count;

            //反转
            int x = totalCount / k;
            for (int i = x; i >= 1; i--)
            {
                //（i*k-1）~（i*k-k）
                for (int j = (i - 1) * k; j < (i - 1) * k + k / 2; j++)
                {
                    //交换
                    Node node = listNodes[j];
                    int reverse = 2 * i * k - (k + 1) - j;
                    listNodes[j] = listNodes[reverse];
                    listNodes[reverse] = node;
                }
            }

            for (int i = 0; i < totalCount; i++)
            {
                //重新计算next节点
                if (i < x * k)
                {
                    if (i < totalCount - 1)
                    {
                        listNodes[i].Next = listNodes[i + 1].Address;
                    }
                    else
                    {
                        listNodes[i].Next = -1;
                    }
                }

                //打印
                Console.WriteLine(string.Format("{0} {1} {2}",
                                                listNodes[i].Address.ToString("00000"),
                                                listNodes[i].Data,
                                                listNodes[i].Next.Equals(-1) ? listNodes[i].Next.ToString() : listNodes[i].Next.ToString("00000")));

            }

            //Console.ReadKey();
        }

    }

    class Node
    {
        public int Address { get; set; }

        public int Data { get; set; }

        public int Next { get; set; }
    }
}
