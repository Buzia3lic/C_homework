Console.Write("Please enter number 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Please enter number 2: ");
int n2 = int.Parse(Console.ReadLine());
if (n1 == n2)
{
    Console.WriteLine($"Number {n1} and number {n2} are equal!");
}
else
{
    if (n1 > n2)
    {
        Console.WriteLine($"Number {n1} is the MAX. Number {n2} - MIN");
    }
    else
    {
        Console.WriteLine($"Number {n2} is the MAX. Number {n1} - MIN");
    }
}
