Console.Write("Please enter num А: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Please enter degree B: ");
int pow = int.Parse(Console.ReadLine());

int Mult(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}

if (pow < 0)
{
    Console.Write("Degree must be greater than 0!");
}
else
{
    Console.Write($"Number {num} in degree {pow} is: {Mult(num, pow)}");
}

