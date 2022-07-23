/*
__Урок 7. Как не нужно писать код. Часть 1_______________________________________________________________________

Задача 47. Задайте двумерный массив размером m × n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] CreateRandom2dArray(int m, int n)
{
    double[,] newArray = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}
 
System.Console.WriteLine("Enter parametr m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter parametr n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arrayZ = CreateRandom2dArray(m, n);
Show2dArray(arrayZ);
*/
/*
_________________________________________________________________________
Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же 
 указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ShowElement(int[,] myArray, int m, int n)
{
    if (m >= 0
    && n >= 0
    && m <= myArray.GetLength(0) - 1
    && n <= myArray.GetLength(1) - 1)
    {
        for (int i = 0; i <= m; i++)
            for (int j = 0; j <= n; j++)
                if (i == m && j == n)
                {
                    Console.WriteLine(myArray[i, j]);
                }
    }
    else
    {
        Console.Write("There is no such element in the array!");
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowElement(myArray, m, n);
*/
/* 
_________________________________________________________________________
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ArithmeticMeanColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0; i < columns; i++)
    {
        double sumAvg = 0;
        for (int j = 0; j < rows; j++)
        {
            sumAvg += array[j,i];
        }    
        sumAvg = Math.Round(sumAvg / rows,1);
        
        Console.Write("Average columns {0} is: {1} ;", i,sumAvg);
    }   
}


Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
ArithmeticMeanColumns(myArray);
