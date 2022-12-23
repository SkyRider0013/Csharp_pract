//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите значения m и n для задания двумерного массива");
Console.WriteLine("Введите целое положительное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число, для проверки его наличия в данной матрице");
int find = Convert.ToInt32(Console.ReadLine());
int counter = 0;

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

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i,j] == find)
            {
                counter++;
            }
        }
    }

    if (counter > 0)
    {
        Console.WriteLine($"Искомое число {find} встречается {counter} раз в данном массиве");
    }
    else
    {
        Console.WriteLine($"Искомова числа {find} нет в данном массиве");
    }
}
else
{
    Console.WriteLine("Введены недопустимые значения m или n - повторите программу снова");
}