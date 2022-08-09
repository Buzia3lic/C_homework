Console.Write("Please enter length: ");
int size = int.Parse(Console.ReadLine());
int count = 2;
if (size > 1)
{
    Console.Write("All 'even numbers': ");
    for (count = 2; count < (size - 2); count += 2)
    {
        Console.Write($"{count}, ");
    }
    Console.Write($"{count}. ");
}
else
{
    if (size <= 0)
    {
        Console.Write("Length must be greater than 0!");   
    }
    else
    {
        Console.Write("There is no 'even numbers'!");
    }
}


