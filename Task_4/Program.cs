// Показать четные числа от 1 до N
int first = 1;
Console.WriteLine("Эта программа выведет на экран все чётные числа от единицы до того, которое Вы выберете включительно.");
Console.WriteLine("Введите последнее число множества (положительное).");
int last = Convert.ToInt32(Console.ReadLine());
int between = last - first;
Console.WriteLine($"Ниже выведены все чётные числа от {first} до {last}");
int count = 1;
int i = first + 1;
Console.Write($"{i} ");
while (count < between/2)
{
    i = i + 2;
    count = count + 1;
    Console.Write($"{i} ");
}