using System;
using System.Collections.Generic;
using System.Globalization;

namespace Solving_Problems
{
    public class PhoneNumbers
    {
        static Dictionary<char, char[]> phoneNumbers = PhoneNumbers.GetPhoneNumbers();

        private static Dictionary<char, char[]> GetPhoneNumbers()
        {
            return new Dictionary<char, char[]>()
                {
                    {'1' , new []{'i', 'j'}},
                    {'2' , new []{'a', 'b', 'c'}},
                    {'3' , new []{'d', 'e', 'f'}},
                    {'4' , new []{'g', 'h'}},
                    {'5' , new []{'k', 'l'}},
                    {'6' , new []{'m', 'n'}},
                    {'7' , new []{'p', 'r', 's'}},
                    {'8' , new []{'t', 'u', 'v'}},
                    {'9' , new []{'w', 'x', 'y'}},
                    {'0' , new []{'o', 'q', 'z'}},
                };
        }

        public static void Run()
        {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;

            do
            {
                string currentNumber = inputData[index];
                index++;
                int dictionaryWordsCount = int.Parse(inputData[index], nfi);
                index++;
                var wordsDictionary = CreateWordsDictionary(inputData, index, index += dictionaryWordsCount);

                string output = GetOutputWords(currentNumber, wordsDictionary, 0);

                Console.WriteLine(output);
            } while (inputData[index] != "-1");
        }

        private static string GetOutputWords(string currentNumber, Dictionary<char, List<string>> wordsDictionary, int index)
        {
            if (index >= currentNumber.Length) return "";

            var numberCharacters = phoneNumbers[currentNumber[index]];

            var paths = new List<string>();

            foreach (var numberCharacter in numberCharacters)
            {
                if (!wordsDictionary.ContainsKey(numberCharacter)) continue;

                var availableWords = wordsDictionary[numberCharacter];
                string currentPath = "";

                foreach (var availableWord in availableWords)
                {
                    if (getPathLength(currentPath + availableWord) > currentNumber.Length)
                    {
                        currentPath = "";
                    }
                    else
                    {
                        currentPath += availableWord;

                        var nextWord = GetOutputWords(currentNumber, wordsDictionary, index + availableWord.Length);

                        if (nextWord == "No solution.")
                        {
                            currentPath = "No solution.";
                        }
                        else
                        {
                            currentPath += " " + nextWord;
                        }
                    }

                    paths.Add(currentPath);
                }
            }

            paths.RemoveAll(delegate(string s) { return s.Equals("No solution."); });

            if (paths.Count == 0)
            {
                return "No solution.";
            }

            string pathToReturn = paths[0];

            foreach (var path in paths)
            {
                if (path.Length < pathToReturn.Length)
                {
                    pathToReturn = path;
                }
            }

            return pathToReturn.Trim();
        }

        public static int getPathLength(string path)
        {
            if (string.IsNullOrEmpty(path)) return 0;
            string[] words = path.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int pathLength = 0;

            foreach (var word in words)
            {
                pathLength += word.Length;
            }
            return pathLength;
        }

        public static Dictionary<char, List<string>> CreateWordsDictionary(string[] inputData, int start, int end)
        {
            var wordsDictionary = new Dictionary<char, List<string>>();

            for (int i = start; i < end; i++)
            {
                string word = inputData[i];
                char wordStartChar = inputData[i][0];

                if (wordsDictionary.ContainsKey(wordStartChar))
                {
                    wordsDictionary[wordStartChar].Add(word);
                }
                else
                {
                    wordsDictionary.Add(wordStartChar, new List<string> { word });
                }
            }

            return wordsDictionary;
        }
    }
}
