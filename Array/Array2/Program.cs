Random random = new Random();

int[] ints = Enumerable.Range(1,10).Select(_ => random.Next(20, 40)).ToArray();

for (int i = ints.Length - 1; i >= 0; i--)
{
    Console.Write(ints[i] + " ");
}

Console.WriteLine();
Console.WriteLine();

foreach (int i in ints)
{
    Console.Write(i + " ");
}

Console.WriteLine();
Console.WriteLine();

int sum = 0;

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] % 2 == 0)
    {
        sum += ints[i];
    }
}

Console.WriteLine($"Sum = {sum}");

int sumLinq = ints.Where(el => el % 2 == 0).Sum();

Console.WriteLine($"SumLinq = {sumLinq}");
Console.WriteLine();

int min = ints[3];

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] < min)
        min = ints[i];
}

Console.WriteLine($"Min = {min}");

int minLinq = ints.Min();

Console.WriteLine($"MinLinq = {minLinq}");

Console.WriteLine();
Console.WriteLine("Массив из уникальных элементов:");
for (int i = 0; i < ints.Length; i++)
{
    bool isUnique = true;

    for (int j = 0; j < i; j++)
    {
        if (ints[i] == ints[j])
        {
            isUnique = false;
        }
    }

    if (isUnique)
    {
        Console.Write(ints[i] + " ");
    }
}

Console.WriteLine("\n\nМассив из уникальных элементов с linq");
Console.WriteLine(String.Join(" ", ints.Distinct().ToArray()) + "\n");

Console.WriteLine("Отсортированный массив c linq:");
Console.WriteLine(String.Join(" ", ints.OrderBy(el => el).ToArray()));

Console.WriteLine("\nОтсортированный массив c методом Sort() класса Array:");
Array.Sort(ints);
Console.WriteLine(String.Join(" ", ints));

