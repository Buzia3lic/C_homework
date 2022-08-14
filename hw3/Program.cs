Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num / 10000 == 0)
{
    Console.Write("Number must be 5 digits!");
}
else
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
    {
        Console.Write("Yes. The number is a palindrome!");
    }
    else
    {
        Console.Write("No. The number IS NOT a palindrome!");
    }
}

