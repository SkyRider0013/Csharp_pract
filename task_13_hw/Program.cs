// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое целое число");
string number = Console.ReadLine(); // запись всего, что было введено с клавиатуры, допустимо сразу в тип string
// тип string сам по себе по сути является массивом
int number1 = Convert.ToInt32(number); // вводим для проверки на отрицательное значение

if (number1 > 0)
{
    if (number.Length > 2)
    {
        Console.WriteLine("В введённом числе третьей цифрой является " + number[2]);
    }
    else
    {
        Console.WriteLine("В введённом числе нет трёх цифр!");
    }
}
else
{
    if (number.Length > 3)
    {
        Console.WriteLine("В введённом числе третьей цифрой является " + number[3]);
    }
    else
    {
        Console.WriteLine("В введённом числе нет трёх цифр!");
    }
}