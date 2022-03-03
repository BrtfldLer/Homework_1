// Найти максимальное из трех чисел
int a = new Random().Next(0,101);
int b = new Random().Next(0,101);
int c = new Random().Next(0,101);
int max = a;
Console.WriteLine($"Даны три числа: {a}, {b} и {c}");
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"{max} - максимальное из трёх чисел");
