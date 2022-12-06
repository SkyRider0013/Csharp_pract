// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int[] array = new int[3];

Console.WriteLine("Введите трёхзначное число");
int digit123 = Convert.ToInt32(Console.ReadLine());
if (digit123 > 99 && digit123 < 1000)
{
    int digit12 = digit123 / 10;
    int digit2 = digit12%10;
    Console.WriteLine($"в числе {digit123} вторая цифра {digit2}");
}
else
{
    Console.WriteLine("Введено неверное число, введите трёхзначное число");
}