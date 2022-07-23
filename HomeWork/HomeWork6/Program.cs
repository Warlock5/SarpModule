/*
Урок 6. Двумерные массивы и рекурсия
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
_____________________________________________________________________________________
*/
/*
int[] CreateArray(int size)
{
int[] newArray = new int[size];

Console.WriteLine("Creating array here: ");
for(int i = 0; i < size; i++)
{
    System.Console.Write($"Input {i +1} element: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine();
return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int AmountDigitPositve(int[]array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        amount++;
    }
    return amount;
}


System.Console.WriteLine("Input massiv size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arrayM = CreateArray( size);
ShowArray(arrayM);
int amount = AmountDigitPositve(arrayM);
System.Console.WriteLine(amount);


/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
_____________________________________________________________________________________

k1*x+b1=k2*x+b2
x=(b2-b1)/(k1-k2)
y=k1(b2-b1)/(k1-k2)+b1
x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1

*/

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    if (k1 == k2 && b1 == b2)
        Console.WriteLine("The lines don't intersect! ");
    else
        Console.Write($"Point of intersection of given lines: ({x}; {y})");
}


System.Console.Write("Enter value k1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter value b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter value k2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter value b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Intersection(b1, k1, b2, k2);


