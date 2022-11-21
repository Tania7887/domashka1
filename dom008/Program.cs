// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N;
int a = 2;
Console.Write ("Enter the number: ");
N = int.Parse(Console.ReadLine()!);

while (a <= N)
{
    if (a % 2 == 0)
    { 
        Console.WriteLine(a + " ");
        a = a + 1;
    }

    a ++;
}
