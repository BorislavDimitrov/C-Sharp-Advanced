using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsToSearchFor = Console.ReadLine().Split().ToList();
            Dictionary<string, int> wordNumber = new Dictionary<string, int>();

            using StreamReader sr = new StreamReader(@"C:\TEMP\WordCountInput.txt");
            {
                using StreamWriter sw = new StreamWriter(@"C:\TEMP\WordCountOutput.txt");
                {
                    while (!sr.EndOfStream)
                    {
                        List<string> line = sr.ReadLine().Split().Select(x => x.Trim(new char[] { '-', '.', '?', ',', '!' })).Select(x => x.ToLower()).ToList() ;

                        for (int i = 0; i < wordsToSearchFor.Count; i++)
                        {
                            for (int j = 0; j < line.Count; j++)
                            {
                                if (wordsToSearchFor[i] == line[j])
                                {
                                    if (wordNumber.ContainsKey(wordsToSearchFor[i]))
                                    {
                                        wordNumber[wordsToSearchFor[i]]++;
                                    }
                                    else
                                    {
                                        wordNumber.Add(wordsToSearchFor[i], 1);
                                    }
                                }
                            }
                        }
                    }

                    wordNumber = wordNumber.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

                    foreach (var word in wordNumber)
                    {
                        sw.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }

        }
    }
}
