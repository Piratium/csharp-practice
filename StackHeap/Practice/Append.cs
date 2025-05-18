class Append
{
    private int newElement;
    private int[] myCopiedArray;

    private void Initialize(ref int[] myArray)
    {
        Console.Write("Введите целое число: ");

        if (!int.TryParse(Console.ReadLine(), out newElement))
        {
            Console.WriteLine("Ошибка: введено не целое число!");
            myArray = null;
            return;
        }

        myCopiedArray = myArray;
        myArray = new int[myArray.Length + 1];
    }

    public void AppendStart(ref int[] myArray)
    {
        Initialize(ref myArray);
        if (myArray == null) return;
        for (int i = 1; i < myArray.Length; i++)
            myArray[i] = myCopiedArray[i - 1];

        myArray[0] = newElement;
    }

    public void AppendEnd(ref int[] myArray)
    {
        Initialize(ref myArray);
        if (myArray == null) return;
        for (int i = 0; i < myArray.Length - 1; i++)
            myArray[i] = myCopiedArray[i];

        myArray[^1] = newElement;
    }

    public void AppendById(ref int[] myArray)
    {
        Console.WriteLine($"Размер массива: {myArray.Length - 1}");
        Console.Write("Введите индекс элемента: ");
        if (!int.TryParse(Console.ReadLine(), out int index))
        {
            Console.WriteLine("Формат индекса неверный!");
            myArray = null;
            return;
        }

        Initialize(ref myArray);
        if (myArray == null) return;

        myArray[index] = newElement;

        for (int i = 0; i < index; i++)
            myArray[i] = myCopiedArray[i];

        for (int i = index; i < myCopiedArray.Length; i++)
            myArray[i + 1] = myCopiedArray[i];
    }
}