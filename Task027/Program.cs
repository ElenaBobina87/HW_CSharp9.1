// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SetNamber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetSum(int start, int end, int sum = 0)
{
    if (start == end) return sum + end;
    else return sum = start + GetSum(start + 1, end);
}

int M = SetNamber("M");
int N = SetNamber("N");
System.Console.WriteLine(GetSum(M, N));
