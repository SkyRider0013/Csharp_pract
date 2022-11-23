// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа для определения наибольшего из них");
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine());
int max;

if (A > B)
    {
        max = A;
        if (max > C)
        {
            Console.Write(max);
            Console.WriteLine(" - максимальное число");
        }        
    }
else
    {
        if (B > C)
        {
            max = B;
        }
        else
        {
            max = C;
        }
    }
Console.Write(max);
Console.WriteLine(" - максимальное число");