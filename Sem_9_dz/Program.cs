﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

/*Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}*/

// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
string PrintReversedNumber(int start, int end)
{
    if (start == end) return Convert.ToString(start);
    return PrintReversedNumber(start + 1, end) + " " + start;
}

Console.Write($"{n} -> ");
Console.Write(PrintReversedNumber(1, n));*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = SumInRange(m, n);
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {result}");
    
    static int SumInRange(int m, int n)
    {
        if (m == n)
            return n;
        else
            return m + SumInRange(m + 1, n);
    }*/
