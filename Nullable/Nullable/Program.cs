// Null-совместимые значимые типы (Nullable)

// Т.к. string ссылочный тип, в него можно положить null
string str = null;

// В int нельзя, т.к. он значимый тип. Он принимает данные, а не ссылку на данные
// Иногда нам нужно получать какие-то данные от базы данных и к примеру SQLite может в int хранить null
// Для такого случая есть фича Nullable
DateTime? dateTime = null;

// Добавляя "?" постфиксом к типу данных, в объявленной переменной можно хранить null

// У null-совместимых значимых типов есть 2 поля

int? number = 2;
Console.WriteLine(number.HasValue); // Поле хранит булево значение с проверкой хранятся ли в переменной данные
Console.WriteLine(number.Value);    // Поле хранит значение переменной

int? i = 3;

Console.WriteLine(i); // Вывод 3

Console.WriteLine(i == null); // Вывод false

Console.WriteLine(i.HasValue); // Вывод true

Console.WriteLine(i.GetValueOrDefault()); // Вывод 3

Console.WriteLine(i.GetValueOrDefault(1)); // Вывод 3

Console.WriteLine(i ?? 19); // Вывод 3

Console.WriteLine(i.Value); // Вывод 3

int? nothing = null;

Console.WriteLine(nothing); // Выведет пустоту

Console.WriteLine(nothing == null); // Вывод true

Console.WriteLine(nothing.HasValue); // Вывод false

Console.WriteLine(nothing.GetValueOrDefault()); // Вывод 0

Console.WriteLine(nothing.GetValueOrDefault(1)); // Вывод 1

Console.WriteLine(nothing ?? 19); // Вывод 19

Console.WriteLine(nothing.Value); // Вывод InvalidOperationException