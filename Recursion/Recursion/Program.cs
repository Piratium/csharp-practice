//void Foo(int i)
//{
//    Console.WriteLine("Foo");

//    if (i >= 3) return;
//    i++;
//    Foo(i);
//}

//Foo(0);

Item InitItem()
{
    return new Item()
    {
        Value = 5,
        Child = new Item()
        {
            Value = 10,
            Child = new Item()
            {
                Value = 20,
            }
        }
    };
}

void Print (Item item)
{
    if (item!=null)
    {
        Console.WriteLine(item.Value);
        Print(item.Child);
    }
}

Item item = InitItem();

//Print(item);

// Та же реализация, но не рекурсией, а циклом
for (Item i = item; i != null; i = i.Child)
{
    Console.WriteLine(i.Value);
}

class Item
{
    public int Value { get; set; }
    public Item Child { get; set; }
}