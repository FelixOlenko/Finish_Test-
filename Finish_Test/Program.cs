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