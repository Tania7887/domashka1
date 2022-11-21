// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
Console.Write ("Enter the number: ");
a = Console.Read ();

if (a % 2 == 0)
{
   Console.WriteLine ("Even number");
}

else
{
    Console.WriteLine ("Odd number");
}

