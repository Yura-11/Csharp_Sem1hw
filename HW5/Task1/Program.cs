// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива" );
int size = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[size];
int count = 0;
FillArrayRandomNumbers(numb);
PrintArray(numb);


for (int index = 0; index < numb.Length; index++)
{
    if (numb[index] % 2 == 0)
    count++;
}


Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.WriteLine();
}