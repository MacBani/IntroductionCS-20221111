// 70. Показать натуральные числа от 1 до N, N задано
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(showNumber(1, N));

string showNumber(int a, int N)
{
    if (a > N) { return String.Empty; }
    else { return $"{a}" + " " + showNumber(a + 1, N); }

}

