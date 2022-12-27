// 75. Написать программу вычисления функции Аккермана - 5*
int n = 3;
int m = 5;
System.Console.WriteLine(FncAck(n, m));

int FncAck(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FncAck(n - 1, 1);
    }
    else
    {
        return FncAck(n - 1, FncAck(n, m - 1));
    }
}