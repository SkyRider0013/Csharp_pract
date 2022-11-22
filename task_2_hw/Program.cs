// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, отличное от первого");
int B = Convert.ToInt32(Console.ReadLine());

if (A == B)
{
    Console.WriteLine("Введены два одиноаковых числа");
}
else
{
    if (A > B)
    
        {
            Console.Write(A);
            Console.WriteLine(" - максимальное число");
            Console.Write(B);
            Console.WriteLine(" - минимальное число");
        }
    else
        {
            Console.Write(B);
            Console.WriteLine(" - максимальное число");
            Console.Write(A);
            Console.WriteLine(" - минимальное число");
        }
}