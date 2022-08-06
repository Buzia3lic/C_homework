Console.Write("Please enter number: ");
int n1 = int.Parse(Console.ReadLine());
if (n1 == 0)
{
    Console.Write($"You entered {n1}. This is a 'neutral number'");
}
else
{
    if (n1 % 2 == 0)
    {
        Console.Write($"The number {n1} IS! 'even number'");
    }
    else
    {
        Console.Write($"The number {n1} IS NOT! 'even number'");
    }
}