// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму н
// атуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (n < m) 
{
    Console.WriteLine ("Число N должно быть больше или равно M");
}
while (n < m)
{
Console.Write("Введите число N: ");
n = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}:");

int summaNM = SummaNat(m, n);
Console.WriteLine(summaNM);

int SummaNat(int m,int n)
{
    int summa = n;
    if (n == m) 
    {
        return summa;
    }
else 
{
    summa=n + SummaNat(m, n-1);
    return summa;
}
}





