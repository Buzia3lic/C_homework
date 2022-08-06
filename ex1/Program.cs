Console.Write("Please enter number 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Please enter number 2: ");
int n2 = int.Parse(Console.ReadLine());
int sqr = n2 * n2;
if (sqr == n1)
{
    Console.WriteLine($"Number {n1} IS the square of the {n2}");
}
else
{
   Console.WriteLine($"Number {n1} IS NOT the square of the {n2}");
}
