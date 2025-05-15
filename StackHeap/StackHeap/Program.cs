static void Foo (int myInt)
{
    myInt = 11;
}

static void Bar (int[] myArr)
{
    myArr[0] = 1;
}

int a = 1;

Foo(a);
Console.WriteLine(a);

int[] arr = new int[3];
Console.WriteLine("Массив исходный");
foreach (int item in arr)
    Console.Write(item + " ");

Bar(arr);
Console.WriteLine();
Console.WriteLine("\nМассив измененный");
foreach (int item in arr)
    Console.Write(item + " ");

// Шок, но string - ссылочный тип
string myStr = "sad";
