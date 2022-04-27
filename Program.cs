using SentenceOperation;

Console.WriteLine("Please, enter sentence.");
var sentence = Console.ReadLine();

Console.WriteLine($"Percent of asked chars in sentence = {Sentence.PercentOfCertainChars(sentence)}");

Console.WriteLine($"Amount of concatinations with entered substring = {Sentence.AmountOfConcatination(sentence)}");

Console.WriteLine($"Amount of words in sentence = {Sentence.AmountOfWords(sentence).ToString()}");

Console.WriteLine($"Word builded from first letters of the words in entered sentence = {Sentence.FirstLetterWord(sentence)}");

Console.WriteLine($"Amount of vowel letters in sentence = {Sentence.AmountOfVowel(sentence)}");

Console.WriteLine($"There are " + (Sentence.GotFiveSymbolsInRow(sentence) ? "" : "no") + " 5 identical letters in a sentence.");

Console.WriteLine($"Sentence after changing every third char = {Sentence.ChangeThirdSymbol(sentence)}");

Console.WriteLine($"Sentence in reverse order = {Sentence.ReverseOrder(sentence)}");

Console.WriteLine($"All words in sentence = {Sentence.WriteAllInclusions(sentence)}");