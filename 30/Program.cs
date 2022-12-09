// 30.	Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число до которого будет производится умножение: ");
int N = Convert.ToInt32(Console.ReadLine());
Multiplication(N);

void Multiplication(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{A} * {i} = {A * i}");
    }
}
