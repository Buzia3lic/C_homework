Console.Write("Enter the number of levels: ");
int num = int.Parse(Console.ReadLine());

void star(int a)
{
    Console.Write("*");
    for (int i = 0; i < a; i++)
    {
        Console.Write("**");
    }
}

void space(int b, int c)
{
    for (int i = b - 1 - c; i > 0; i--)
    {
        Console.Write(" ");
    }
}


if (num <= 0)
{
    Console.Write("ERROR: It is not possible to create a tree! The number must be greater than 0.");
}
else
{
    for (int i = 0; i < num; i++)
    {
        space(num, i);
        star(i);
        Console.WriteLine();
    }
}
