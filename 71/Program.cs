// 71. Показать натуральные числа от N до 1, N задано
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(showNumber(N, 1));

string showNumber(int N, int a)
{
    if (N < a) { return String.Empty; }
    else { return $"{N}" + " " + showNumber(N - 1, a); }

}
