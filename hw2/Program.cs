Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
int a3 = 0;

if (num/100 == 0)
{
    Console.WriteLine("There is no the third number!");
}
else
{
    Console.WriteLine($"The third number is: {(num % 1000)/100}");
}

