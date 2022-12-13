// 33.	Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] ma = new int[8];
putM(ma);
showM(ma);

void putM(int[] m)
{
    Random rnd = new Random();
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = rnd.Next(0, 2);
    }
}

void showM(int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        System.Console.Write(m[i] + " ");
    }
}
