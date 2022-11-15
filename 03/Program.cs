//С клавиатуры вводя два числа a и b. Найти максимальное из них.
Console.WriteLine("Введите два числа:");
int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());

if(a >= b){
Console.WriteLine($"{a} - max");
}

if(a < b){
Console.WriteLine($"{b} - max");
}

