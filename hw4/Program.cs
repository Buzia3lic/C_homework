Console.Write("Enter array length: ");
int numAr = int.Parse(Console.ReadLine());
if (numAr <= 0) goto End;
Console.Write("Enter min value: ");
int minAr = int.Parse(Console.ReadLine());
Console.Write("Enter max value: ");
int maxAr = int.Parse(Console.ReadLine());

void RandArr(int num, int min, int max)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        //Console.Write($"{arr[i]} ");
    }
    Console.WriteLine($"[{String.Join(",", arr)}]");
}

RandArr(numAr, minAr, maxAr);

End:
if (numAr <= 0) Console.Write("Array creation is not possible!");