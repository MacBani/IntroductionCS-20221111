// 7. Выяснить является ли число чётным.
Console.WriteLine("Введите число: ");

double number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0)
{
Console.WriteLine($"Число {number} - четное");
} 
else 
{
    Console.WriteLine($"Число {number} - нечетное");
}