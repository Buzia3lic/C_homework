Console.Write("Please enter number 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Please enter number 2: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Please enter number 3: ");
int n3 = int.Parse(Console.ReadLine());
int max = n1;
if (n2 > max)
{
    max = n2;
}
if (n3 > max)
{
    max = n3;
}
Console.Write($"Max number is {max}");
