// 35.	Написать программу замены элементов массива на противоположные
int[] ma = { 1, 2, 3, 4, 5 }; // Как я понял должны получить {5 4 3 2 1}
showM(ma);
change(ma);
showM(ma);

void change(int[] m)
{
    int size = m.Length;
    int a;
    for (int i = 0; i < m.Length / 2; i++)
    {
        a = m[i];
        m[i] = m[size - 1];
        m[size - 1] = a;
        size--;
    }
}

void showM(int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        System.Console.Write(m[i] + " ");
    }
    System.Console.WriteLine();
}
