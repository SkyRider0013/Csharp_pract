// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите целое положительное число");
string? number = Console.ReadLine();
int numberN = Convert.ToInt32(number);

int SumNumber(int numberN)
{
    int length = number.Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < length; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine($"сумма цифр числа {number} равняется {sumNumber}");



/* есть вопрос, я старался решить эту задачу через цикл со сложение элементов массива,
но элементы массива никак упорно не хотели складываться нормально,
при сложении 1 и 0 выходило число 49, я так и не понял как устранить эту проблему
Код прошлый прикладываю ниже

Console.WriteLine("Введите целое положительное число");
string? number = Console.ReadLine();
int length = number.Length;

for (int i = 0; i < length; i++)
{
    //Console.WriteLine($"элемент под номером {i} равен {number[i]}");
    result = result + number[i];
    //Console.WriteLine($"промежуточный результат на шаге {i} равен {result}");
}

Console.WriteLine($"сумма цифр числа {number} равняется {result}");*/