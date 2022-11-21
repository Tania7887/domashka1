// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 12;
int b = 5;
int c = -5;
int max = a;

if (b > a)
{
   max = b;
}

 else
 {
    max = a;
 }

if (c > max)
{
    max = c;
}

Console.Write ("max ");
Console.WriteLine (max);



