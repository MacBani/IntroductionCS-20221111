// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number%10);