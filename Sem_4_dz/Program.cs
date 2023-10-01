// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write($"Введите чило А: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"Введите чило B: ");
int b = int.Parse(Console.ReadLine());
int exp = a;

for (int i = 1; i < b; i++)
{
exp = exp * a;
}
Console.WriteLine("A в степени B равно: " + exp);

//Задача 27: Напишите программу, которая принимает на вход //число и выдаёт сумму цифр в числе.
//using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n =  ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void Mass(int col)
{
    int[] array = new int[]{1,2,5,7,19};
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = new Random().Next(0, 9);
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"\b\b]");
}

 Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
 Mass(arrayLength);
Console.WriteLine();