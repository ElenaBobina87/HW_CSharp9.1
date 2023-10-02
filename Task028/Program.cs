//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int SetNamber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Akerman(m - 1, 1);
        else return Akerman(m - 1, Akerman(m, n - 1));
}

int m = SetNamber("m");
int n = SetNamber("n");
System.Console.WriteLine(Akerman(m, n));