// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] ma = new int[123];

putM(ma);
showM(ma);

void putM(int[] m)
{
    Random rnd = new Random();
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = rnd.Next(0, 124);
    }
}

void showM(int[] m)
{
    int count = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if (m[i] > 9 && m[i] < 100)
        {
            count++;
        }
        System.Console.Write(m[i] + " ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел лежащих на отрезке [10;99] = {count} ");
}
