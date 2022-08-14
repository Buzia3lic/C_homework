Console.Write("Enter X0: ");
int x0 = int.Parse(Console.ReadLine());
Console.Write("Enter Y0: ");
int y0 = int.Parse(Console.ReadLine());
Console.Write("Enter Z0: ");
int z0 = int.Parse(Console.ReadLine());
Console.Write("Enter X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter Z1: ");
int z1 = int.Parse(Console.ReadLine());

if (x0 == x1 && y0 == y1 && z0 == z1) 
{ 
    Console.Write("The coordinates of the points are the same!"); 
}
else
{
    double length = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2) + Math.Pow(z0 - z1, 2));
    Console.Write($"The length is: {length:f2}");
}
