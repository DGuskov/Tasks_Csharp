//напишите программу, которая на входе принимает число и выдает его квадрат/
// Например:
// 4 -> 16; -3 ->9; -7 -> 49.

Console.Clear();
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
// 1 metod
int result1 = a*a;
Console.WriteLine($"способ 1 -> Квадрат числа {a} равен {result1}");
// 2 metod
int result2 = Convert.ToInt32(Math.Pow(a,2));
Console.WriteLine($"способ 2 -> Квадрат числа {a} равен {result2}");
