// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
Console.Write("Введите строку: ");
string s = Console.ReadLine();
char simbol = '.';
int count = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == simbol)
    {
        break;
    }
    else
    {
        count++;
    }


}
Console.WriteLine(count);
