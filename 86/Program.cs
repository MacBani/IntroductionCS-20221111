// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
Console.Write("Введите строку: ");
string s = Console.ReadLine();
char simbol = 'a';
int count = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == simbol)
    {
        count++;
    }
}
Console.WriteLine(count);