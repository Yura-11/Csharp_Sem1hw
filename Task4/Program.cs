// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
Console.WriteLine("Четные числа от 1 до "+n);
while (a <= n)
{
    
    if (a % 2 == 0)
    {
       Console.Write(a + " "); 
    }
    a++;
}
