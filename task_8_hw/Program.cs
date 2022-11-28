// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число для показа всех чётных чисел от 1 до выбранного числа");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i < N; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
}
else
{
    Console.WriteLine("Введено число меньшее или равное нулю");
}