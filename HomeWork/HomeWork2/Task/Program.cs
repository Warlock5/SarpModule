/*1)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int SecondOrderNumber()
{
int num;
    Console.WriteLine("Input number from 100 to 1000: "); 
    num = Convert.ToInt32(Console.ReadLine());

    int SecondOrderNumber = num / 10 % 10;
    return (SecondOrderNumber);    
}

int result = SecondOrderNumber();
Console.WriteLine("Result number is " + result);

/*____________________________________________________________________
2)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
 Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int ThirdDigit()
{
int num;
    Console.WriteLine("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine()); 
    
  if (num < 100)   
  Console.WriteLine("третьей цифры нет!");
    
  while(num > 1000) num /= 10;
    int result = num % 10;
    return result;
}      
result = ThirdDigit();
System.Console.WriteLine(result);


/*____________________________________________________________________
3))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))

Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
void DayWeek()
{
    int day = new Random().Next(1, 7);
    Console.WriteLine("Random number is " + day);

    if(day <= 5)  
    Console.WriteLine(day + " -Рабочий день");
     
    else
    Console.WriteLine(day + " -Выходной день");
}
DayWeek();

