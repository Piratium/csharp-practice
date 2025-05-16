string myString = null;
//string result;

//if (myString == null)
//    result = "нет данных";
//else
//    result = myString;

//Console.WriteLine(result);

//Console.WriteLine(myString ?? "нет данных");

//Console.WriteLine((myString ?? string.Empty).Length);

//myString ??= "default";
//Console.WriteLine(myString);

int[] GetArray()
{
    int[] myArray = null;
    return myArray;
}

int[] myArray = GetArray();
//myArray ??= new int[0];

//Console.WriteLine($"Кол-во элементов в массиве: {myArray.Length}");
Console.WriteLine($"Сумма элементов массива {myArray?.Sum() ?? 0}");
