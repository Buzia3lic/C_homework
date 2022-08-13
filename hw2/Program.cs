Console.Write("Please enter number of the day of the week: ");
int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 7)
{
    Console.Write("The number is not correct. It must be between 1 and 7!");
}
else
{
    if( num == 6 || num == 7)
    {
        Console.Write("The day is a weekend!");
    }
    else
    {
        Console.Write("The day is a working day. We need to work((");
    }
}