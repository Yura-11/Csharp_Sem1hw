// Проверить явлеется ли пятизначное число полиндромом"
System.Console.WriteLine("Введите 5значное число ");
string numb = Console.ReadLine();
int a = numb.Length;
if( a == 5)
{
    if(numb[0] == numb[4] && numb[1] == numb[3])
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введено не 5значное число");
}
