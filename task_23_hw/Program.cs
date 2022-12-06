// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите любое целое число для нахождения кубов всех чисел от 1 до заданного числа");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number == 0)
{
    Console.WriteLine("Любая степень числа 0 всегда будет 0. Введите другое число");
}
else
{
    Console.Write("Таблица кубов до заданного ");
    for (int i = 0; i < number + 1; i++)
    {
        double current = i;
        current = Math.Pow(current, 3);
        Console.Write(current + " ");
    }
}