// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число, которое хотите возмести в степень");
double number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите степень, в которую хотите возвести число");
double power = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double numberC = number;
for (int i = 1; i < power; i++)
{
    number = number * numberC;
}
//number = Math.Pow(number, power);
Console.WriteLine($"Число {numberC} в степени {power} будет равным {number}");