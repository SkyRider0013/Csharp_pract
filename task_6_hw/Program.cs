﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число для проверки, является ли оно чётным");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs позволяет брать модуль числа

if (a % 2==0)    // выражение "% число" выдаёт остаток при делении на выбранное число
    {
        Console.WriteLine("Введенное число является чётным");
    }
else
    {
        Console.WriteLine("Введенное число является нечётным");
    }