class Append
{
    public void AppendStart(ref int[] myArray)
    {
        Console.Write("Введите целое число: ");
        if (!int.TryParse(Console.ReadLine(), out int newElement))
        {
            Console.WriteLine("Вы ввели не целое число!");
            return;
        }

        int[] myOriginalArray = myArray;
        int myArrayLength = myArray.Length + 1;

        myArray = new int[myArrayLength];

        for (int i = 1; i < myArrayLength; i++)
            myArray[i] = myOriginalArray[i-1];

        myArray[0] = newElement;
        Console.WriteLine(string.Join(" ",myArray));
    }
}