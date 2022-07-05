/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/
/*
int a, b;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{ 
    Console.WriteLine("max= " + a);
    Console.WriteLine("min= " + b);
}
if(b > a)
{
    Console.WriteLine("max= " + b);
    Console.WriteLine("min= " + a);
}
*/
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*int a, b, c, max;
a = 0; b = 0; c = 0;


Console.Write("Введите число a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
c = Convert.ToInt32(Console.ReadLine());

 max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max= " + max);
*/


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int num;
int del;

System.Console.WriteLine("Input number: ");
num = Convert.ToInt32(System.Console.ReadLine());
 del = num / 2;
 if(del * 2 == num)
 {
    System.Console.WriteLine("Четное ");
 }
else
{
    System.Console.WriteLine("Нечетное ");
}
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на 
выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
int a, b;
*/
/*
int n, current;

Console.WriteLine("Input number: ");
n = Convert.ToInt32(Console.ReadLine());

current = 2;

if(n % 2 == 0)
    while(current <= n)
{
    System.Console.WriteLine(current + " ");
        current = current + (2);
}
*/

