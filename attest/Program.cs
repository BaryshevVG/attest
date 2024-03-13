//Задание 1.

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