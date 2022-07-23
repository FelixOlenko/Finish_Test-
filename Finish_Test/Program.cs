using System;

Console.WriteLine("Введите массив строк поочередно через Enter,\nвведите пустую строку, чтобы завершить ввод");
var inputArray = ReadArray();
var outputArray = RemoveBigEntries(inputArray);
Console.WriteLine("Слова в которых не более 3-х символов:");