// Задание 35, по ошибке написал, что 36 Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
int Interval(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            counter = counter + 1;
        }
    }
    return counter;
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

int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Число значений массива, лежащих в интервале [10,99] равно {Interval(array)}");