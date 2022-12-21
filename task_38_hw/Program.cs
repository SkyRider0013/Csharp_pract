// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

void PrintArray(double[] col)               
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        Console.Write("; ");
        position++;
    }
}
double FindMax(double[] arr)
{
    int length = arr.Length;
    double max = arr[0];
    for (int i = 0; i < length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
double FindMin(double[] arr)
{
    int length = arr.Length;
    double min = arr[0];
    for (int i = 0; i < length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

Console.WriteLine("Введите кол-во элементов массива. Их должно быть больше 1");
int length = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.Write("Введённый массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент в заданном массиве равен {FindMax(array)}, а минимальный равен {FindMin(array)}");