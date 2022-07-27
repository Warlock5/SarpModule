/*
Урок 9. Как не нужно писать код. Часть 3
Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во
цифр в числе N рекурсивным методом.
N = 4532 -> 4
*/

/*
int NumberOfDigits(int n)
{
    if (n < 0) n = n * (-1);
    int count = 0;
    if (n > 0)
    {
        count += 1;
        return count + NumberOfDigits(n / 10);
    }
    return count;
}

Console.Write("Input numbers: ");
int n = Convert.ToInt32(Console.ReadLine());
int digit = (NumberOfDigits(n));
Console.Write($"The number of digits in the number N: {digit}");
*/


/*
Задача 66: 
Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int IntervalSum(int m, int n)
{
    int sum = 0;
    if (n >= m)
    {
        sum = sum + n % 10;
        return sum + IntervalSum(m, n - 1);

    }
    return sum;
}

Console.Write("Enter the beginning of the interval Value m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter end of interval value n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Sum = IntervalSum(m, n);
Console.Write($"The sum of the interval from M to N is equal to: {Sum}");

