void WriteUserName ()
{
    Console.Write("Введите своё имя: ");
    Console.WriteLine($"\nПривет, {Console.ReadLine()}!");
}

//WriteUserName();

int[] myArray = { 6, 3, 1, 6, 4, 8, 2, 1, 3, 9 };
foreach (int i in myArray)
    Console.Write(i + " ");

Console.WriteLine("\n");

myArray.MyIndex(2).PrintMyIndex();

string strr = "Hello";
strr.MyIndex('l').PrintMyIndex();




