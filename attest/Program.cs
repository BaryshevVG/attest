﻿//Задание 1.

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
void PrintNum(int number2)
{
    if (number1 > number2)
    {
        return;
    }
    PrintNum(number2 - 1);
    Console.Write($"{number2} ");
}

Console.WriteLine("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
PrintNum(number2);

// Задание 2

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}