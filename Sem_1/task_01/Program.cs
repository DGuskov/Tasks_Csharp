// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// написать программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// например:
// 25, 5 -> да;  
// 2, 10 -> нет;  
// 9, -3 -> да;  
// -3, 9 -> нет.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int result = b*b;
if (a == result)
{
Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго!");
}
else Console.WriteLine("Не является");