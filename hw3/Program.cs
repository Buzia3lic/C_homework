Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"All cubed numbers for numbers 1 to {num}: ");
int i = 0;
for (i = 1; i < num; i++)
{
    Console.Write($"{i}^3={Math.Pow(i, 3)}, ");
}
Console.WriteLine($"{i}^3={Math.Pow(i, 3)}.");
