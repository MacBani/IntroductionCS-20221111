// 43.	С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] ma = new int[N];
int count = 0;
System.Console.WriteLine($"Введите {N} чисел: ");
for (int i = 0; i < N; i++)
{
    ma[i] = Convert.ToInt32(Console.ReadLine());
    if (ma[i] > 0)
    {
        count++;
    }
}

showM(ma);
System.Console.WriteLine($"Количество введёных положительных чисел: {count} ");


void showM(int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        System.Console.Write(m[i] + " ");
    }
    System.Console.WriteLine();
}
