﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numb3 = Convert.ToInt32(Console.ReadLine());
int max = numb1;
if (numb1 > max) max = numb1;
if (numb2 > max) max = numb2;
if (numb3 > max) max = numb3;


Console.Write("max = ");
Console.WriteLine(max);




