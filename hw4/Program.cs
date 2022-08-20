Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Sum(int a)
{
    if (a == 0)
    {
        return -1;
    }

    if (a < 0)
    {
        a *= -1;
    }

    int sum = 0;
    while (a != 0)
    {
        sum += a % 10;
        a /= 10;
    }

    return sum;
}

if (Sum(num) == -1)
{
    Console.Write($"Цифр нет");
}
else
{
    Console.Write($"Сумма цифр в числе {num} равна: {Sum(num)}.");
}