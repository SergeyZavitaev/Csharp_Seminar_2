Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000)
    Console.WriteLine((number / 10) % 10);
else
    Console.WriteLine("Число должно быть трёхзначным");