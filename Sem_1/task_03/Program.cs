// написать программу которая на вход принимает одно чисто (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine());
int index = -N;
while (index <= N)
{
    Console.Write($"{index}, ");
    index++;
}