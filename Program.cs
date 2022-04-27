using SentenceOperation;

Console.WriteLine("Please, enter sentence.");
var sentence = Console.ReadLine();

Console.WriteLine($"Percent of asked chars in sentence = {Sentence.PercentOfCertainChars(sentence)}");