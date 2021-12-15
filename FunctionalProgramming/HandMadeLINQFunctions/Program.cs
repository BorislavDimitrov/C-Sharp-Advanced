using System;
using System.Collections.Generic;
using System.Linq;

namespace HandMadeLINQFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Select(x => x * 100)
              .Where(x => x / 2 == 50)
              .ToList();
            
            Action<List<int>> Print = PrintList;
            Print(numbers);

            List<string> text = (Split2(Console.ReadLine() , " "));
            List<int> text2 = Select2( text , x => int.Parse(x));
            text2 = Select2(text2, x => x * 100);
            text2 = Where2(text2 , x => x / 2 == 50);
            PrintList(text2);            
        }

        static  List<string> Split2(string input , char symbolToSplitBy)
        {
            List<string> newList = new List<string>();
            string currentWord = string.Empty;
            foreach (var character in input)
            {
                if (character != symbolToSplitBy)
                {
                    currentWord += character;
                }
                else if (character == symbolToSplitBy)
                {
                    newList.Add(currentWord);
                    currentWord = string.Empty;
                }
            }

            return newList;
        }

        static List<string> Split2 (string input , string textToSplitBy)
        {
            List<string> newList = new List<string>();
            string currentWord = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                currentWord += input[i];
                if (currentWord.Contains(textToSplitBy))
                {
                    currentWord = currentWord.Replace(textToSplitBy, string.Empty);
                    if (currentWord.Length > 0)
                    {
                        newList.Add(currentWord);
                        currentWord = string.Empty;
                    }
                }

                if (i == input.Length - 1 && currentWord.Length > 0)
                {
                    newList.Add(currentWord);
                    currentWord = string.Empty;
                }
            }

            return newList;
        }

        static List<string> Split2(string input , char[] symbolsToSplitBy)
        {
            List<string> newList = new List<string>();
            string currWord = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (symbolsToSplitBy.Contains(input[i]))
                {
                    if (currWord.Length > 0)
                    {
                        newList.Add(currWord);
                        currWord = string.Empty;
                    }
                }
                else
                {
                    currWord += input[i];
                }

                if (i == input.Length - 1 && currWord.Length > 0)
                {
                    newList.Add(currWord);
                }
            }
            return newList;
        }

        static List<string> Split2(string input , string[] textsToSplitBy)
        {
            List<string> newList = new List<string>();
            string currWord = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                currWord += input[i];

                for (int j = 0; j < textsToSplitBy.Length; j++)
                {
                    if (currWord.Contains(textsToSplitBy[j]))
                    {
                        currWord = currWord.Replace(textsToSplitBy[j] , string.Empty);

                        if (currWord.Length > 0)
                        {
                            newList.Add(currWord.Trim());
                            currWord = string.Empty;
                        }
                    }
                }

                if (i == input.Length - 1)
                {
                    newList.Add(currWord.Trim());
                }
            }
            return newList;
        }

        static List<int> Select2 (List<string> input , Func<string , int> toInt)
        {
            List<int> newList = new List<int>();
            foreach (var element in input)
            {
                newList.Add(toInt(element));
            }
            return newList;
        }

        static List<int> Select2(List<int> numbers , Func<int , int> process)
        {
            List<int> newList = new List<int>();
            foreach (var number in numbers)
            {
                newList.Add(process(number));
            }
            return newList;
        }

        static List<int> Where2(List<int> numbers , Func<int , bool> predicate)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (predicate(numbers[i]))
                {
                     newList.Add(numbers[i]);
                }
            }
            return newList;
        }

        static  void PrintList(List<int> numbers) => Console.WriteLine(string.Join(" " , numbers)); 
    }
}
