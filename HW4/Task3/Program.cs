// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




// //По заданию из 8 элементов , но в примерах количество элементов вводиться в ручную поэтому первый пример
// int[] randomArray = new int[8];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next();
//     Console.Write(randomArray[i] + " ");
// }

int longArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[longArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,100);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
