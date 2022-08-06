Console.Write("Please enter length: ");
int size = int.Parse(Console.ReadLine());
int count = 2;
if (size > 1)
{
    Console.Write("All 'even numbers': ");
    while (count <= (size - 2) )
    {
        Console.Write($"{count}, ");
        count += 2;
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


