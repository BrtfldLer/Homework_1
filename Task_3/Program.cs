
// Является ли число чётным?
int number = new Random().Next(-100,101);
int del = number%2;
Console.WriteLine($"Получено случайное число {number}");
Console.WriteLine($"Является ли число {number} чётным?");
if (del == 0)
{
    Console.WriteLine("Является");
}
else
{Console.WriteLine("Не является");
}

