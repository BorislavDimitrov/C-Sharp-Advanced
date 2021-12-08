using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int operationsNumber = int.Parse(Console.ReadLine());
            StringBuilder mainText = new StringBuilder();
            Stack<List<char>> savedChars = new Stack<List<char>>();
            Stack<List<string>> commands = new Stack<List<string>>();

            for (int i = 0; i < operationsNumber; i++)
            {
                List<string> operationInfo = Console.ReadLine().Split().ToList();
                string command = operationInfo[0];

                if (command == "1")
                {
                    string commandArgoument = operationInfo[1];
                    List<string> saveCommandInfo = new List<string>();

                    saveCommandInfo.Add(command);
                    saveCommandInfo.Add(commandArgoument);
                    commands.Push(saveCommandInfo);

                    List<char> argoumentToChars = commandArgoument.ToCharArray().ToList();
                    savedChars.Push(argoumentToChars);

                    foreach (var characater in commandArgoument)
                    {
                        mainText.Append(characater);
                    }
                }
                else if (command == "2")
                {
                    int commandArgoument = int.Parse(operationInfo[1]);
                    List<string> saveCommandInfo = new List<string>();

                    saveCommandInfo.Add(command);
                    saveCommandInfo.Add(commandArgoument.ToString());
                    commands.Push(saveCommandInfo);

                    List<char> argoumentToChars = new List<char>();

                    for (int j = 0; j < commandArgoument; j++)
                    {
                        argoumentToChars.Add(mainText[mainText.Length - 1]);
                        mainText.Remove(mainText.Length - 1 , 1);
                    }
                    argoumentToChars.Reverse();
                    savedChars.Push(argoumentToChars);
                }
                else if (command == "3")
                {
                    int index = int.Parse(operationInfo[1]) - 1;
                    Console.WriteLine(mainText[index]);
                }
                else if (command == "4")
                {
                    List<string> lastCommandList = commands.Pop();
                    string lastCommand = lastCommandList[0];

                    if (lastCommand == "1")
                    {
                        int lastCommandArgoumentCount = savedChars.Pop().Count();

                        for (int k = 0; k < lastCommandArgoumentCount; k++)
                        {
                            mainText.Remove(mainText.Length - 1 , 1);
                        }
                    }
                    else if (lastCommand == "2")
                    {
                        List<char> lastCommandAroument = savedChars.Pop();

                        foreach (var character in lastCommandAroument)
                        {
                            mainText.Append(character);
                        }
                    }
                }
            }
        }
    }
}
