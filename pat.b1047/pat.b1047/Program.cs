using System;
using System.Collections.Generic;

namespace pat.b1047
{
    /// <summary>
    /// PAT.1047
    /// 2016.05.10
    /// by XY
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
            string input = Console.ReadLine();
            int n = int.Parse(input);
            List<int> teamNoList = new List<int>();
            List<int> scoreList = new List<int>();
            while (n > 0)
            {
                //格式为：“队伍编号-队员编号 成绩”
                string inputline = Console.ReadLine();
                string[] inputlist1 = inputline.Split(' ');
                int score = int.Parse(inputlist1[1]);
                string[] inputlist2 = inputlist1[0].Split('-');
                int teamNo = int.Parse(inputlist2[0]);

                //循环遍历。未添加到list里的队伍编号则添加，已经添加的只需要分数累加即可。
                if (teamNoList.Count == 0)
                {
                    teamNoList.Add(teamNo);
                    scoreList.Add(score);
                }
                else
                {
                    bool isIn = false;
                    for (int i = 0; i < teamNoList.Count; i++)
                    {
                        if (teamNo == teamNoList[i])
                        {
                            scoreList[i] += score;

                            isIn = true;
                            break;
                        }
                    }
                    if (!isIn)
                    {
                        teamNoList.Add(teamNo);
                        scoreList.Add(score);
                    }
                } 
                n--;
            }
            int maxTeamNo = 0;
            int maxScore = 0;
            for (int i = 0; i < teamNoList.Count; i++)
            {
                if (scoreList[i] > maxScore)
                {
                    maxTeamNo = teamNoList[i];
                    maxScore = scoreList[i];
                }
            }

            Console.WriteLine("{0} {1}", maxTeamNo, maxScore);
        }
    }
}
