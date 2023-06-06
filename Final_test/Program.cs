/* Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами*/

﻿Console.Clear();
Console.WriteLine("Введите массив строк через пробел: ");
string[] mainArray = Console.ReadLine().Split(" ");
string[] fullArray = new string[mainArray.Length];
void InputArray(string[] mainArray, string[] fullArray)
{
    int x = 0;
    for (int i = 0; i < mainArray.Length; i++)
    {
    if(mainArray[i].Length <= 3)
        {
        fullArray[x] = mainArray[i];
        x++;
        }
    }
}
void PrintArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"{str[i]} ");
    }
    Console.WriteLine();
}
InputArray(mainArray, fullArray);
Console.WriteLine("Вывод массива строк, состоящих из 3x и менее элементов: ");
PrintArray(fullArray);