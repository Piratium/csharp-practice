int[,] myTwoDimensionalArray = new int[,] { { 2, 3, 4, 2 }, { 2, 4, 2, 1 }, { 1, 2, 5, 2 } };

int rows = myTwoDimensionalArray.GetLength(0);
int columns = myTwoDimensionalArray.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(myTwoDimensionalArray[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Заполненение рандомными числами
int[,] nextArray = new int[2,5];

rows = nextArray.GetLength(0);
columns = nextArray.GetLength(1);
Random random = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        nextArray[i,j] = random.Next(10);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(nextArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Ручное заполнение числами через консоль
//string[,] handleCreateArray = new string[2,3];
//rows = handleCreateArray.GetLength(0);
//columns = handleCreateArray.GetLength(1);

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.WriteLine($"Row: {i} Column: {j}");
//        handleCreateArray[i, j] = Console.ReadLine();
//    }
//}

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write(handleCreateArray[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

// Зубчатый массив
int[][] myJaggedArray = new int[3][];

myJaggedArray[0] = new int[3];
myJaggedArray[1] = new int[2];
myJaggedArray[2]  = new int[4];

for (int i = 0; i < myJaggedArray.Length; i++)
{
    for (int j = 0; j < myJaggedArray[i].Length; j++)
    {
        myJaggedArray[i][j] = random.Next(10);
    }
}

for (int i = 0; i < myJaggedArray.Length; i++)
{
    for (int j = 0; j < myJaggedArray[i].Length; j++)
    {
        Console.Write(myJaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Трехмерный зубчатый массив
int[][][] jagaJagaArray = new int[random.Next(3, 5)][][];

for (int i = 0; i < jagaJagaArray.Length; i++)
{
    jagaJagaArray[i] = new int[random.Next(3, 6)][];
    for (int j = 0; j < jagaJagaArray[i].Length; j++)
    {
        jagaJagaArray[i][j] = new int[random.Next(3, 6)];
        for (int k = 0; k < jagaJagaArray[i][j].Length; k++)
        {
            jagaJagaArray[i][j][k] = random.Next(10);
        }
    }
}

for (int i = 0; i < jagaJagaArray.Length; i++)
{
    Console.WriteLine($"Массив массивов №{i+1}");
    for (int j = 0; j < jagaJagaArray[i].Length; j++)
    {
        for (int k = 0; k < jagaJagaArray[i][j].Length; k++)
        {
            Console.Write(jagaJagaArray[i][j][k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}