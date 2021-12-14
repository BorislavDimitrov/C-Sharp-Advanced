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
            string[] wordsToSearch = File.ReadAllLines(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\WordCountWords.txt");
            string[] textLines = File.ReadAllLines(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\WordCountText.txt");
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < textLines.Length; i++)
            {
                List<string> wordsFromLine = textLines[i].Split().Select(x => x.ToLower()).ToList();

                foreach (string word in wordsToSearch)
                {
                    foreach (string wordToSearch in wordsFromLine)
                    {
                        if (word == wordToSearch.Trim(new char[] { '-' , '.' , ',' , '?' , '!'}))
                        {
                            if (wordCount.ContainsKey(word))
                            {
                                wordCount[word]++;
                            }
                            else
                            {
                                wordCount.Add(word , 1);
                            }
                        }
                    }
                }
            }

            wordCount = wordCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key , y => y.Value);
            List<string> results = new List<string>();

            foreach (var word in wordCount)
            {
                results.Add($"{word.Key} - {word.Value}");
            }

            File.AppendAllLines(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\WordCountResult.txt" , results);
        }
    }
}
