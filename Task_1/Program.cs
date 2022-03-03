// Программа на вход принимает два числа и выдаёт какое большее, а какое меньшее.

int A = new Random().Next(-100,101);
int B = new Random().Next(-100,101);
Console.WriteLine($"Даны два числа: {A} и {B}");
if (A>B)
{
    Console.WriteLine($"Большее число - {A}");
    Console.WriteLine($"Меньшее число - {B}");
}
else
{
    Console.WriteLine($"Большее число - {B}");
    Console.WriteLine($"Меньшее число - {A}");
}
