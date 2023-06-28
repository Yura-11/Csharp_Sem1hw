System.Console.WriteLine("Введите число ");
int numb = Convert.ToInt32(Console.ReadLine());

if(numb < 1000 && numb > 100)
{
    System.Console.WriteLine($"Вторая цифра  {numb} является {numb / 10 % 10} ");
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число"); 
}


