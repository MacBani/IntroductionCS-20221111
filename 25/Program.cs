//25.	Вывести на экран кубы чисел от 1 до N
Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Power(N);

void Power(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
}