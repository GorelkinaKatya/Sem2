Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);

while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
    n = int.Parse(Console.ReadLine()!);
}

if (n == 6)
    Console.WriteLine("Этот день выходной");
else if (n == 7)
    Console.WriteLine("Этот день выходной");
else
    Console.WriteLine("Этот день НЕ выходной");

    