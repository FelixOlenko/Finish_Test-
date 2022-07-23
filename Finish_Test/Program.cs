using System;

Console.WriteLine("Введите массив строк поочередно через Enter,\nвведите пустую строку, чтобы завершить ввод");
var inputArray = ReadArray();
var outputArray = RemoveBigEntries(inputArray);
Console.WriteLine("Слова в которых не более 3-х символов:");
for (int i = 0; i < outputArray.Length; i++)
{
    Console.Write($" \"{outputArray[i]}\"; ");
}

static string[] ReadArray()
{
    bool arrayEntered = false;
    string[] words = new string[10];
    for (int i = 0; !arrayEntered; i++)
    {
        if (i + 1 >= words.Length)
        {
            Array.Resize(ref words, (int)Math.Round(words.Length * 1.5));
        }
        string? arrayElement = Console.ReadLine();
        if (String.IsNullOrEmpty(arrayElement))
        {
            Array.Resize(ref words, i);
            arrayEntered = true;
        }
        else
        {
            words[i] = arrayElement;
        }
    }
    return words;
}

static string[] RemoveBigEntries(string[] inputArray)
{
    int newArraySize = 0;
    foreach (string word in inputArray)
    {
        if (word.Length <= 3)
        {
            newArraySize++;
        }
    }
    string[] newArray = new string[newArraySize];
    int currentWord = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        var word = inputArray[i];
        if (word.Length <= 3)
        {
            newArray[currentWord] = word;
            currentWord++;
        }
    }
    return newArray;

}