﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10

System.Console.WriteLine("Введите 1 число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2 число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
if (numb1 > numb2)
{
Console.WriteLine("Максимальное число: "+numb1);
}
else
{
    Console.WriteLine("Максимальное число: "+numb2);
}



