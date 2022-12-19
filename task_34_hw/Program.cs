// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Countable(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            counter = counter + 1;
        }
    }
    return counter;
}
void PrintArray(int[] col)               
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        Console.Write(' ');
        position++;
    }
}
int result = 0;

Console.WriteLine("Введите целое число, чтобы задать размерность массива");
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
int index = 0;

while (index < length)
{
    array[index] = new Random().Next(100, 1000);
    index++;
}

result = Countable(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{result} - количество чётных чисел в заданном массиве");