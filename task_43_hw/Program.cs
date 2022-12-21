// Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значения констант для задания двух пряммых на плоскости");
Console.WriteLine("y = k1*x + b1 и y = k2*x + b2");
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
double x;
double y;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Заданные прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Заданные прямые параллельны и не пересекаются");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Заданные прямые пересекаются в точке с координатами ({x};{y})"); 
}