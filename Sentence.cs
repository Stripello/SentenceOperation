using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceOperation
{
    internal static class Sentence
    {
        internal static decimal PercentOfCertainChars(string sentence)
        {
            Console.WriteLine("Please, enter char for searching in sentence.");
            var userChar = Console.ReadKey().KeyChar;
            int i = 0;
            foreach (var ch in sentence.ToArray())
            {
                if (ch == userChar)
                {
                    i++;
                }
            }
            return (decimal)i*100/sentence.Length;
        }

        internal static int AmountOfConcatination(string sentence)
        {
            Console.WriteLine("Please, enter some substring to search.");
            var userSubstring = Console.ReadLine();
            var answer = 0;
            for (int i = 0; i <= sentence.Length - userSubstring.Length; i++)
            {
                if (sentence[i..].StartsWith(userSubstring))
                {
                    answer++;
                }
            }
            return answer;
        }

        internal static int AmountOfWords(string sentence)
        {
            var sentenceArray = sentence.Split(' ');
            return sentenceArray.Length;
        }

        internal static string FirstLetterWord(string sentence)
        {
            var sentenceArray = sentence.Split(' ');
            var answer = new StringBuilder();
            foreach (var element in sentenceArray)
            {
                answer.Append(element[0]);
            }
            return answer.ToString();
        }

        internal static int AmountOfVowel(string sentence)
        {
            var vowels = "EYUIOAАИОУЫЭ";
            var answer = 0;
            foreach (var ch in sentence.ToUpper())
            {
                if (vowels.Contains(ch))
                {
                    answer++;
                }
            }
            return answer;
        }

        internal static bool GotFiveSymbolsInRow(string sentence)
        {
            var tempChar = sentence[0];
            int seriesCount = 1;
            for (int i = 1; i < sentence.Length; i++)
            {
                if (tempChar == sentence[i])
                {
                    seriesCount++;
                    if (seriesCount == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    tempChar = sentence[i];
                    seriesCount = 1;
                }
            }
            return false;
        }

        internal static string ChangeThirdSymbol(string sentence)
        {
            Console.WriteLine("Please< enter symbol for change.");
            var replacingChar = Console.ReadKey().KeyChar;
            var tempArray = sentence.ToCharArray();
            for (int i = 3; i < sentence.Length; i = i + 3)
            {
                tempArray[i] = replacingChar;
            }
            return new string (tempArray);
        }

        internal static string ReverseOrder(string sentence)
        {
            var tempArray = sentence.Split(' ');
            tempArray = tempArray.Reverse().ToArray();
            return string.Join(" ", tempArray);
        }


    }
}
