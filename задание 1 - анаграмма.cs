Console.WriteLine("Введите строку 1");
string? a = Console.ReadLine();
a = a.ToLower();
Console.WriteLine("Введите строку 2");
string? b = Console.ReadLine();
b = b.ToLower();
a = String.Concat(a.OrderBy(c => c));
b = String.Concat(b.OrderBy(c => c));
if (a == b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("NO");
}
