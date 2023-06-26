// написать программу, которая будет выводить название дня недели по нормеру
// например:
// 3 -> среда
// 5 -> пятница

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
if (a < 1 || a > 7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}
if (a==1)
{
    Console.WriteLine("Понедельник");
}
if (a==2)
{
    Console.WriteLine("Вторник");
}
if (a==3)
{
    Console.WriteLine("Среда");
}
if (a==4)
{
    Console.WriteLine("Четверг");
}
if (a==5)
{
    Console.WriteLine("Пянтица");
}
if (a==6)
{
    Console.WriteLine("Суббота");
}
if (a==7)
{
    Console.WriteLine("Воскресенье");
}