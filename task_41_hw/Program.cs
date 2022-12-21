// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
int PositivNumbers(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            counter = counter + 1;
        }
    }
    return counter;
}

Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());

if (length == 0)
{
    Console.WriteLine("Вы ввели 0 - массив пустой");
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

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введённый массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Число элементов массива больших нуля равно {PositivNumbers(array)}");