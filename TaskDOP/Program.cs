Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n <= 0 || n > 100)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    n = int.Parse(Console.ReadLine()!);
}

int max1 = n;

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
while (m <= 0 || m > 100)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    m = int.Parse(Console.ReadLine()!);
}
int max2 = 0;
if (max1 < m)
{
    max2 = max1;
    max1 = m;
}
else max2 = m;

int i = 2; //Кол-во введенных чисел

while (n != 0 && i < 98) //Для того, чтобы пользователь ввел максимум 98 чисел, чтобы 99 обязательно был 0
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine()!);

    while (n < 0 || n > 100)
    {
        Console.Write("Вы ошиблись!\nВведите число: ");
        n = int.Parse(Console.ReadLine()!);
    }

    if (max1 < n)
    {
        max2 = max1;
        max1 = n;
    }
    else if (max2 < n)
        max2 = n;
    
    i++;
}

Console.Write($"Второе максимальное число до нуля: {max2}");
    