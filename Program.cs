//Задача:
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решение не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System;

string[] arr = { "Hello", "2", "world", ":-)" };
//string[] arr = { "1234", "1567", "-2", "computer science" };
//string[] arr = { "Russia", "Denmark", "Kazan" };

string[] ArrayElementNoMoreThree(string[] arr)
{
    string[] newArr = new string[arr.Length];
    int count = 0;
    int maxLenght = 3;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLenght)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    newArr = newArr.Where(x => x != null).ToArray();
    return newArr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

    Console.WriteLine("Исходный массив: ");
    PrintArray(arr);
    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
    string[] EndArray = ArrayElementNoMoreThree(arr);
    Console.ForegroundColor = ConsoleColor.Red;
    PrintArray(EndArray);
    Console.ResetColor();
    Console.WriteLine();