/*
Урок 8. Как не нужно писать код. Часть 2
_________________________________________________________________________
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 ПО УБЫВАНИЮ элементы(т.е. цифры) каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7 |                                                     | 7 4 2 1
2 3 5 9 | ПРИМЕР НЕВЕРЕН- МАССИВ УПОРЯДОЧЕН ПО ВОЗРАСТАНИЮ!!! | 9 5 3 2
2 4 4 8 |                                                     | 8 4 4 2
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


void DecreaseArray(int[,] array)
{


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
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
Console.WriteLine();
DecreaseArray(myArray);

*/

/*
______________________________________________________________________
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
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


int SmallerString(int[,] array)
{
    int minSum = 0;
    int StringNum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            temp += array[j, i];
        }
        if (temp > minSum)
        {
            minSum = temp;
            StringNum = i;
        }
    }

    return StringNum;
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
int SmaillStr = SmallerString(myArray);
System.Console.WriteLine($"Row with the lowest amount: {SmaillStr}");

*/
/*
______________________________________________________________________
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
 1  2  3 4
12 13 14 5
11 16 15 6
10  9  8 7
*/


Console.Write("Enter the size of the square array: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Matrix = new int[n, n];
Show2dArray(Matrix);
Console.WriteLine();
int[,] Spiral = CreateSpire(Matrix);
Show2dArray(Spiral);


/*
int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
    Matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1) j++;
    else
    if (i < j && i + j >= Matrix.GetLength(0) - 1) i++;
    else
    if (i >= j && i + j > Matrix.GetLength(1) - 1) j--;
    else
        i--;
}

for (i = 0; i < Matrix.GetLength(0); i++)
    for (j = 0; j < Matrix.GetLength(1); j++)
    {
        Console.Write($"{Matrix[i,j]} "); // 
    }

*/
int[,] CreateSpire(int[,] array)
{
    int temp = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n - i; j++) Matrix[i, j] = temp++;
        {
            for (int k = i + 1; k < n - i; k++) Matrix[k, n - 1 - i] = temp++;
            {
                for (int j = n - i - 2; j >= i; j--) Matrix[n - 1 - i, j] = temp++;
                {
                    for (int k = n - 2 - i; k > i; k--) Matrix[k, i] = temp++;                                        
                }
            }
        }
    }
    return Matrix;
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


