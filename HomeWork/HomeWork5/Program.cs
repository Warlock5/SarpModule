/*Урок 5. Функции продолжение
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if( array[i] %2 == 0) count++;
    
    return count;
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arrayZ = CreateRandomArray(size);
ShowArray(arrayZ);
int NumberEven = EvenNumbers(arrayZ);
System.Console.WriteLine("Number of even: " + NumberEven);

*/
/*
_____________________________________________________________________
Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
/* 
int[] CreateRandomArray(int size)
{
   int[] newArray = new int[size];

   for (int i = 0; i < size; i++)
       newArray[i] = new Random().Next(-100, 1000);

   return newArray;
}

void ShowArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();
}

int sumOfOdd(int[] array)
{
   int sum =0;

   for (int i = 0; i < array.Length; i+= 2)
     sum += array[i];

   return sum;
} 

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] arrayZ = CreateRandomArray(size);
ShowArray(arrayZ);
int OddSum = sumOfOdd(arrayZ);
System.Console.WriteLine("Sum of odd: " + OddSum);

*/
/*
_____________________________________________________________________
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        newArray[i] = 5 - rand.Next(11) + rand.NextDouble();
    }

    return newArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double Diference(double[] array)
{
    double min = array[0];
    double max = array[0];
    double Dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
        Dif = max - min;
    }
    return Dif;
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());


double[] arrayZ = CreateRandomArray(size);
ShowArray(arrayZ);
double Dif = Diference(arrayZ);
System.Console.WriteLine("The difference between the maximum and minimum: " + Dif);

