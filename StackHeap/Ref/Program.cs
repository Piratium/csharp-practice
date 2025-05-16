// Передаем значение
void Foo(int a)
{
    a = 10;
}

// Передаем ссылку (адрес) на значение
void Bar(ref int b)
{
    b = 10;
}

int a = 5;
int b = 5;

Foo(a);
Bar(ref b);

//Console.WriteLine("a = " + a);
//Console.WriteLine("b = " + b);

void NewValueStruct(ref MyStruct myStruct)
{
    myStruct.a = 5;
}

MyStruct myStruct = new MyStruct();

NewValueStruct(ref myStruct);

//Console.WriteLine(myStruct.a);

void ChangeValueClass(MyClass myClass)
{
    myClass.a = 5;
}
// В параметр передается копия ссылки на данные в памяти
void NullClass(MyClass myNullClass)
{
    myNullClass = null;
}

MyClass myClass = new MyClass();

ChangeValueClass(myClass);

//Console.WriteLine(myClass.a);

// Т.к. мы разорвали связь именно с копией ссылки, а не с оригинальной, myClass всё ещё указывает на наши данные
NullClass(myClass);
//Console.WriteLine(myClass.a);

// Чтобы изменить именно ссылку myClass, можно использовать оператор ref

// Здесь мы предаем параметром ссылку на ссылку 
void ChangeLink(ref MyClass myNewClass)
{
    myNewClass = new MyClass() { a = 6, b = 6, c = 6 };
}

ChangeLink(ref myClass);
//Console.WriteLine($"{myClass.a}{myClass.b}{myClass.c}");

// == Про ссылочные локальные переменные ==

int[] myArray = { 1, 2, 3 };
int myInt = myArray[0];
myInt = 5;

Console.WriteLine($"myInt:\t\t{myInt}");
Console.WriteLine($"myArray:\t{string.Join(" ", myArray)}");

// Здесь нет никакой связи между массивом myArray и переменной myInt
// Можно использовать оператор ref и тогда связь появится
// Изменяя myInt, будет изменяться связанный с ним элемент массива

ref int myLinkedInt = ref myArray[0];
myLinkedInt = 5;

Console.WriteLine($"\nmyLinkedInt:\t{myLinkedInt}");
Console.WriteLine($"myArray:\t{string.Join(" ", myArray)}");

// == Про возвращаемые ссылочные значения ==

ref int ChangeArrayValue(int[] myNewArray)
{
    return ref myNewArray[0];
}

// Передаем значение по ссылке в ссылочную локальную переменную
ref int mySecondLinkedInt = ref ChangeArrayValue(myArray);

mySecondLinkedInt = 9;

Console.WriteLine($"\nmySecLinkedInt:\t{mySecondLinkedInt}");
Console.WriteLine($"myArray:\t{string.Join(" ", myArray)}");

// Голова уже кругом идет от этих рефов xd