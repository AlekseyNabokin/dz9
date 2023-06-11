// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if (n>0)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n-1);
//     }
// }
// Console.WriteLine("Input number N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Amount(int m, int n)
{
    if (m==n)
    return n;
    else return m + Amount(m + 1, n);
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"The sum of natural elements in the range from M to N is equal to {Amount(m,n)}");