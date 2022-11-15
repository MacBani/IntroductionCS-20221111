// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
Console.Write("Введите два числа: a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите два числа: b = ");
int b = Convert.ToInt32(Console.ReadLine());

if(b % a == 0){
    Console.WriteLine($"Число {b} кратно {a}");
} else{
    Console.WriteLine($"Остаток от деления {b} на {a} = {b % a}");
}