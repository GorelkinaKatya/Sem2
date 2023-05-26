Console.Clear();
Console.Write("Введите положительное трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);

while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись! Введите положительное трехзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}

Console.WriteLine(n / 10 - n / 100 * 10);