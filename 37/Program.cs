// 37.	Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] ma = new int[10];
putM(ma);
showM(ma);


void putM(int[] m)
{
    Random rnd = new Random();
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = rnd.Next(100, 1000);
    }
}

void showM(int[] m)
{
    int count = 0;

    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] % 2 == 0)
        {
            count++;
        }
        System.Console.Write(m[i] + " ");
    }
    System.Console.WriteLine();
    int nechet = m.Length - count;
    System.Console.WriteLine($"Количество четных чисел - {count}");
    System.Console.WriteLine($"Количество нечетных чисел - {nechet}");
}