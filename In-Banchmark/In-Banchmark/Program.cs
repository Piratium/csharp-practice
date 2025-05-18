using System.Diagnostics;

void Foo(Point a) { }

void Bar(in Point a) { }

Point a = new Point();

Stopwatch sw = Stopwatch.StartNew();

for (int i = 0; i < int.MaxValue; i++)
    Foo(a);

sw.Stop();
Console.WriteLine($"Foo: {sw.ElapsedMilliseconds}");

sw.Restart();

for (int i = 0; i < int.MaxValue; i++)
    Bar(a);

sw.Stop();
Console.WriteLine($"Bar: {sw.ElapsedMilliseconds}");