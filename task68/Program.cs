﻿// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m, n) = n + 1, если m = 0,
// A(m, n) = A(m - 1, 1), если m <> 0, n = 0,
// A(m, n) = A(m - 1, A(m, n - 1)), если m> 0, n > 0.

Console.Clear();
Console.Write("Введите число m не более 3: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Akkerman(m - 1, 1);
return Akkerman(m - 1, Akkerman(m, n - 1));
}
