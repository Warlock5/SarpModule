/*
4. Функции продолжение
Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int DigitSum(int N)
{
 int result = 0;
 while(N > 0)
 {
    result += N % 10;
    N = N /10;
 }
 return result;
} 
    
System.Console.Write("Input number: ");
int num = Convert.ToInt32(System.Console.ReadLine());
int result = DigitSum(num);
System.Console.WriteLine(DigitSum(num));




/*
____________________________________________________________________________
Задача 29: Напишите программу, которая задаёт массив из m элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] array = { 1, 2, 5, 7, 19 };

for(int i =0; i < array.Length; i ++)
    Console.Write(array[i] + " ");

System.Console.WriteLine();

