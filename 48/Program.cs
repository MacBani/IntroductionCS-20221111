// 48.	Написать программу копирования массива

int N = 5;
int[] m = new int[N];
putM(m);
int[] copym = copyM(m);
showM(m);
showM(copym);


int[] copyM(int[] ma)
{
    int[] mas = new int[ma.Length];
    ma.CopyTo(mas, 0);
    return mas;
}

void putM(int[] m)
{
    Random rnd = new Random();
    for (int i = 0; i < m.Length; i++)
    {
        m[i] = rnd.Next(0, 9);
    }
}

void showM(int[] m)
{
    for (int i = 0; i < m.Length; i++)
    {
        Console.Write(m[i] + " ");
    }
    Console.WriteLine();
}