﻿Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99){
    while (number>999){
        number=number/10;
    }
    Console.WriteLine((number % 10));
}
else
    Console.WriteLine("Третьей цифры нет");