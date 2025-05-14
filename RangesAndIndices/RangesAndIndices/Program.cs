int[] ints = Enumerable.Range(1,15).ToArray();

Console.WriteLine(String.Join(" ", ints) +"\n");

Console.WriteLine(String.Join(" ", ints[4..^2]));

// Index myIndex = ^1;
Index myIndex = new Index(1, true);
Console.WriteLine(ints[myIndex]);

// Range myRange = 1..5
Range myRange = new Range(1,5);
Console.WriteLine(string.Join(" ", ints[myRange]));

string myString = "Hello world! :D";
Console.WriteLine(myString[6..11]);
Console.WriteLine(myString[^2..^0]);

foreach (var i in myString[3..5])
    Console.Write(i);
Console.WriteLine(myString[^6]);