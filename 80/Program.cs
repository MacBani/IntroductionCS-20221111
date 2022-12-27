// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

for (int i = 32; i < 123; i++)
{
    Console.WriteLine($"{i} - " + (char)i);
}