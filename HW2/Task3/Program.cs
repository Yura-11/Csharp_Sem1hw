Console.WriteLine("Введите число дня недели:");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb<5 && numb >= 1)
{
    Console.WriteLine("нет");
}
else if (numb>5 && numb<=7)
{
  Console.WriteLine("да");  
}
else
{
    Console.WriteLine("Это не день недели");
}

    
     