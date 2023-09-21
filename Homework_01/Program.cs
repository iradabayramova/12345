// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int a = 5;
int b = 7;
if(b > a)
  Console.WriteLine("b bolshe");
if(b < a)
  Console.WriteLine("b menshe");
else
 
  Console.WriteLine("a menshe");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a1 = 22;
int b1 = 3;
int c1 = 9;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("VVedite chislo: ");
int N=Convert.ToInt32(Console.ReadLine());
int Chetnoye=N;

if(N % 2 == 0){
          System.Console.Write(" chetnoye ");
          }
else
     {
          System.Console.Write(" nechetnoye ");
         }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("VVedite chislo: ");
int number=Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
       evenNumber = evenNumber + 2;
    }
}
