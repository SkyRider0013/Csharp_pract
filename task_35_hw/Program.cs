// Задание 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

void PrintArray(int[] col)               
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
void FillArray(int[] collection)          
{
    int lenght = collection.Length;      
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 1000); 
        index++;
    }
}
int NotCount(int[] arr)
{
    int length = arr.Length;
    int result = 0;
    int index = 0;

    while (index < length)
    {
        result = result + arr[index];
        index = index + 2;
    }
    return result;
}

Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());

if (length == 0)
{
    Console.Write("Вы ввели 0 - массив пустой");
}
else 
{
    if (length < 0)
    {
        Console.WriteLine("Вы ввели отрицательное значени. В данной прогремме мы будем рассматривать это число по модулю");
        length = Math.Abs(length);
    }
}
int[] array = new int[length];
FillArray(array);
Console.Write("Наш массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечётных елементов массива равна {NotCount(array)}");