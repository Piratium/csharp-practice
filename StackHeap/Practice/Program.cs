﻿#region Метод изменяющий кол-во элементов массива
//void Resize(ref int[] myNewArray)
//{
//    Console.Write("Введите кол-во элементов массива: ");
//    int size = int.Parse(Console.ReadLine());
//    myNewArray = new int[size >= 0 ? size : 0];
//}

//int[] myArray = new int[3];
//Console.WriteLine($"Иссходный размер массива: {myArray.Length}");

//Resize(ref myArray);

//Console.WriteLine($"Измененный размер массива: {myArray.Length}");
#endregion

//int.TryParse(Console.ReadLine(), out int result);
//Console.WriteLine(result);

int[] myArray = { 1, 2, 3 };
Append appendArray = new Append();

appendArray.AppendById(ref myArray);

Console.WriteLine(string.Join(" ", myArray ?? new int[0]));

