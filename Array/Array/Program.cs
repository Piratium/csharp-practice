

int[] ints = [2, 4];
int[] ints1 = new int[5] { 1, 2, 3, 4, 5 };

Random random = new Random();


int[] myArray = Enumerable.Range(1, 100).Select(_ => random.Next(1,20)).ToArray();

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");
}

Console.WriteLine();

int[] myArray2 = new int[10];

Console.WriteLine("Введите числа для массива");

for (int i = 0; i < myArray2.Length; i++)
{
    myArray2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

foreach (int i in myArray2)
{
    Console.Write(i + " ");
}


int length = 5;

for (int i = 0; i < length + 1; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = length; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = length; i > 0; i--)
{
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= length - i; k++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = length; i > 0; i--)
{
    for (int j = 0; j < length - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= i - 1; k++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}