// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число из диапазона [10, 99]: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a / 10;
int c = a % 10;

Console.WriteLine($"Наибольшая цифра числа - {Math.Max(b, c)}");

