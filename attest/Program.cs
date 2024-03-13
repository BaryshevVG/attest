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
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunction(m,n));

// Задание 3
void ReverseArray(int[] arr, int iter = 0)
{
    if (iter < arr.Length)
    {
        ReverseArray(arr, iter + 1);
        Console.Write($"{arr[iter]}, ");
    }
}
int[] arr = [1, 7, 12, 44, 55, 78, 99];
ReverseArray(arr);