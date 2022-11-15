// 5. клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.WriteLine($"Введите три числа: ");

double number_1 = Convert.ToDouble(Console.ReadLine());
double number_2 = Convert.ToDouble(Console.ReadLine());
double number_3 = Convert.ToDouble(Console.ReadLine());

double maximum = Math.Max(number_1, number_2);
maximum = Math.Max(maximum, number_3);
Console.WriteLine($"Макисимальное число из введённых: {maximum}");

