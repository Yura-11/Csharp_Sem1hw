//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int numb1 = ReadInt("Введите первое число : ");
int numb2 = ReadInt("Введите второе число : ");
Degree(numb1, numb2);

void Degree(int numb1, int numb2)
{
    int result = 1;
    for (int i = 1; i <= numb2; i++)
    {
        result = result * numb1;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
