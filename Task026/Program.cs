// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int SetNamber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string Natural(int N)
{
    if (N >= 1) return $"{N} " + Natural(N - 1);
    else return String.Empty;
}

int N = SetNamber("N");
System.Console.WriteLine(Natural(N));