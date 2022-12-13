// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размерность массива (для данной задачи он должен быть равен 8, но это не принципиально)");
int length = Convert.ToInt32(Console.ReadLine());

/*int WriteArray(int length)
{
    length = Math.Abs(length);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array; ----- что тут нужно возвращать, чтобы данная функция заработала???
}
*/

if (length == 0)
{
    Console.Write("Вы ввели 0 - массив пустой");
}
else if (length < 0)
{
    Console.WriteLine("Вы ввели отрицательное значени. В данной прогремме мы будем рассматривать это число по модулю");
    length = Math.Abs(length);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Получившийся массив равен: " + '[' + string.Join(", ", array) + ']');
}
else
{
    length = Math.Abs(length);
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Получившийся массив равен: " + '[' + string.Join(", ", array) + ']');
}