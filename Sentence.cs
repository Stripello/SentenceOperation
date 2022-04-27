using System.Text;

namespace SentenceOperation
{
    internal static class Sentence
    {
        internal static decimal PercentOfCertainChars(string sentence)
        {
            Console.WriteLine("Please, enter char for searching in sentence.");
            var userChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
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
            Console.WriteLine("Please enter symbol for change.");
            var replacingChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            var tempArray = sentence.ToCharArray();
            for (int i = 3; i < sentence.Length; i += 3)
            {
                tempArray[i] = replacingChar;
            }
            return new string (tempArray);
        }

        internal static string ReverseOrder(string sentence)
        {
            var tempArray = sentence.Split(' ');
            if (tempArray.Last().EndsWith('.'))
            {
                tempArray[^1] = tempArray[^1][..(tempArray.Length - 2)];
                tempArray[0] = tempArray[0] + '.';
            }
            if (Char.IsUpper(tempArray[0][0]))
            {
                tempArray[0] = tempArray[0].ToLower();
                tempArray[^1] =Char.ToUpper(tempArray.Last()[0]) + tempArray[^1][1..];
            }


            tempArray = tempArray.Reverse().ToArray();
            return string.Join(" ", tempArray);
        }

        internal static string WriteAllInclusions(string sentence)
        {
            Console.WriteLine("Please, enter all words to search using whitespace as divider.");
            var arrayForSearching = Console.ReadLine().Split(' ');
            var sentenceArray = sentence.Split(' ');
            for (int i=0; i < sentenceArray.Length; i++)
            {
                if (!Char.IsLetterOrDigit(sentenceArray[i].Last()))
                {
                    sentenceArray[i] = sentenceArray[i][0..(sentenceArray[i].Length-2)];
                }
            }

            var answer = new StringBuilder();
            foreach (var word in sentence.Split(' '))
            {
                if (arrayForSearching.Contains(word))
                {
                    answer.Append(word);
                    answer.Append(' ');
                }
            }
            return answer.ToString();
        }
    }
}
