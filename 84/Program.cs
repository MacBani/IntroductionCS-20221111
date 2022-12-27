// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа
Console.Write("Введите символы через пробел: ");
string s = Console.ReadLine();
string[] ss = s.Split(" ");
char[] n = new char[ss.Length];
int sum = 0;

for (int i = 0; i < ss.Length; i++)
{
    n[i] = Convert.ToChar(ss[i]);
    if (n[i] >= '0' && n[i] <= '9')
    {
        sum += n[i] - '0';
    }
}
Console.WriteLine(sum);