﻿Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int a = n;
int i = 1;

if (n < 99)
    Console.Write("Третьей цифры нет");
else if (n > 100 && n < 999)
    Console.Write($"Третья цифра: {n % 10}");
else
{
    while (a > 999)
    {
        i = i * 10;
        a = n / i;
    }
    Console.Write($"Третья цифра: {a % 10}");
}