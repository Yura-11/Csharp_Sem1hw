﻿//  
//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//  Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//  
 
int[,] mass = new int[4, 4];

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void MinSumNumb(int[,] array)
{
    int minnumb = 0;
    int minSumnumb = 0;
    int sumnumb = 0;
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        minnumb += mass[0, i];
    }
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++) sumnumb += mass[i, j];
        if (sumnumb < minnumb)
        {
            minnumb = sumnumb;
            minSumnumb = i;
        }
        sumnumb = 0;
    }
    Console.Write($"{minSumnumb + 1} строка");
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArrayRandom(mass);
PrintArray(mass);
Console.WriteLine();
MinSumNumb(mass);
