System.Console.WriteLine("Введите координаты 1 точки через пробел :");
int[] fc = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
System.Console.WriteLine("Введите координаты 2 точки через пробел:");
int[] sc = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int A = (int)(Math.Pow(fc[0]-sc[0], 2));
int B = (int)(Math.Pow(fc[1]-sc[1], 2));
int C = (int)(Math.Pow(fc[1]-sc[1], 2));

System.Console.WriteLine(Math.Round(Math.Sqrt(A + B + C), 2));
