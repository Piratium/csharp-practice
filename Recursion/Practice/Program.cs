int[] ints = { 1, 2, 3, 4, 5 };

void Print(int[] ints, int i = 0)
{
    if (i >= ints.Length) return;
    Console.WriteLine(ints[i]);
    Print(ints, i + 1);
}

int Sum(int[] ints, int i = 0)
{
    if (i >= ints.Length) return 0;
    return ints[i] + Sum(ints, i + 1);
}

//Print(ints);

Console.WriteLine(Sum(ints));