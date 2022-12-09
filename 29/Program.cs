// 29.	Подсчитать сумму цифр в числе. Сделать подпрограмму.

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(counter(A));

int counter(int A)
{
    String B = Convert.ToString(A);
    int cnt = 0;


    for (int i = 0; i < B.Length; i++)
    {
        cnt += (B[i] - '0');
    }


    return cnt;
}