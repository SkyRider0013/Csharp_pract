// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите значения m и n для задания двумерного массива");
Console.WriteLine("Введите целое положительное число m строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double result = 0;

if (m > 0 && n > 0)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(0,10);
            Console.Write(matrix[i,j] + " ");  
        }
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result = result + matrix[j,i];
        }
        result = result / m;
        array[i] = result;
        result = 0;
    }

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"{Math.Round(array[i], 2)} - среднее арифметическое {i+1} столбца");
    }
}
else
{
    Console.WriteLine("Введены недопустимые значения m или n - повторите программу снова");
}