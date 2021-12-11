using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsPasswords = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> contestants = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                List<string> contestInfo = input.Split(":").ToList();
                string contestName = contestInfo[0];
                string contestPass = contestInfo[1];

                contestsPasswords.Add(contestName , contestPass);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                List<string> submissionInfo = input.Split("=>").ToList();
                string contestName = submissionInfo[0];
                string contestPassword = submissionInfo[1];
                string contestantName = submissionInfo[2];
                int contestantPoints = int.Parse(submissionInfo[3]);

                if (contestsPasswords.ContainsKey(contestName))
                {
                    if (contestsPasswords[contestName] == contestPassword)
                    {
                        if (contestants.ContainsKey(contestantName))
                        {
                            if (contestants[contestantName].ContainsKey(contestName))
                            {
                                if (contestants[contestantName][contestName] < contestantPoints)
                                {
                                    contestants[contestantName][contestName] = contestantPoints;
                                }
                            }
                            else
                            {
                                contestants[contestantName].Add(contestName , contestantPoints);
                            }
                        }
                        else
                        {
                            contestants.Add(contestantName , new Dictionary<string, int>());
                            contestants[contestantName].Add(contestName , contestantPoints);
                        }
                    }
                }
            }

            int bestPoints = 0;
            string bestContestant = string.Empty;

            foreach (var contestant in contestants)
            {
                if (contestant.Value.Sum(x => x.Value) > bestPoints)
                {
                    bestPoints = contestant.Value.Sum(x => x.Value);
                    bestContestant = contestant.Key;                 
                }
            }

            Console.WriteLine($"Best candidate is {bestContestant} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            contestants = contestants.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var contestant in contestants)
            {
                
                Console.WriteLine($"{contestant.Key}");
                foreach (var contest in contestant.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
            
        }
    }
}
