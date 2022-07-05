/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
void Palindrome()
{
int num = new Random().Next(10000, 100000);  
// int num = 56765;
Console.WriteLine("Is this a palindrome? " + num);

int digit1 = num / 10000;
int digit2 = num % 10000 / 1000;
//int digit3 = num % 1000 / 100;
int digit4 = num % 100 / 10;
int digit5 = num % 10;

if(digit1 == digit5 && digit2 == digit4)
System.Console.WriteLine("Yes");
    
else
System.Console.WriteLine("No");
}

Palindrome();

/*__________________________________________________________________
))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Kub()
{
int n, res, current;

Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

current = 1;

while(current <= n) 
{
    res = current * current * current;
    current++;
    System.Console.Write(res + " "); 
    
}
}
Kub();
