static class IndexFind
{
    /// <summary>
    /// Возвращает индекс определенного элемента
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="num"></param>
    /// <returns></returns>
    public static int MyIndex (this int[] arr, int num)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
                return i;
        }
        return -1;
    }

    public static int MyIndex (this string myString, char symbol)
    {
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == symbol)
                return i;
        }
        return -1;
    }

    public static void PrintMyIndex(this int myIndex)
    {
        Console.WriteLine($"Найденный индекс коллекции: {myIndex}");
    }
}