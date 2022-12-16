// 46.	С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int N = 0;
while (N < 2)
{
    Console.WriteLine("Введите число больше единицы: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int[] ma = new int[N];

funcF(ma);
showM(ma);



void funcF(int[] m)
{
    int size = m.Length;
    m[0] = 0;
    m[1] = 1;

    if (size > 2)
    {
        for (int i = 2; i < size; i++)
        {
            m[i] = m[i - 1] + m[i - 2];
        }
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