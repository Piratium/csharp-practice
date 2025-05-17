class Append
{
    private int[] myArray;
    private int[] myCopiedArray;
    private int newElement;
    private int myArrayLength;
    public Append(ref int[] myArray)
    {
        this.myArray = myArray;
        myCopiedArray = this.myArray;
        myArrayLength = myArray.Length + 1;
    }

    private void Initialize()
    {
        Console.Write("Введите целое число: ");
        if (!int.TryParse(Console.ReadLine(), out newElement))
        {
            Console.WriteLine("Вы ввели не целое число!");
            return;
        }
        myArray = new int[myArrayLength];
    }

    public void AppendStart()
    {
        Initialize();
        for (int i = 1; i < myArrayLength; i++)
            myArray[i] = myCopiedArray[i-1];

        myArray[0] = newElement;
        Console.WriteLine(string.Join(" ",myArray));
    }

    public void AppendEnd()
    {
        Initialize();
        for (int i = 0; i < myArrayLength - 1; i++)
            myArray[i] = myCopiedArray[i];

        myArray[^1] = newElement;
        Console.WriteLine(string.Join(" ", myArray));
    }
}