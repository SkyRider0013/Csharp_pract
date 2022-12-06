// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите положительное пятизначное число для проверки его на полиндромность");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number [4] && number[1] == number[3])
    {
        Console.WriteLine("Введённое число является полиндромом");
    }
    else
    {
        Console.WriteLine("Введённое число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятнизначное число");
}