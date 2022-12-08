/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int Secnum(int num)
    {
         int result = num / 10 % 10;
         return result; 
    }
    

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int newnum = Secnum(num);
Console.WriteLine($"Второй цифрой числа {num} является {newnum}");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
num = numStr.Length;
    {
        if (num > 2) Console.WriteLine($"Третья цифра: {numStr[2]}");

        else Console.WriteLine("число состоит из 2х цифр");
    }

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/