static void Foo (int myInt)
{
    myInt = 11;
}

static void Bar (int[] myArr)
{
    myArr[0] = 1;
}

int a = 1;
Console.WriteLine($"Int до Foo(): {a}\n");
Foo(a);
Console.WriteLine($"Int после Foo(): {a}\n");

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
string aaa;
int bbb;
String firstName = new String("Paul");
// Создание ссылки, которая будет храниться в стеке. 
int[] myArray;
// Эту ссылку представляет литерал null.
// Null означает отсутствие данных.
// Т.е. реальных данных, на которые бы указывала ссылка, не существует.

// Выделяем память в управляемой куче.
myArray = new int[3];
// В этот момент создается связь между ссылкой из стека и данными из кучи.

Console.WriteLine("\n\n" + firstName);