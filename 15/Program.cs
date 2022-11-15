// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x = a.ToString().Length;
if(x > 2){
int result = (a / (10^x)) % 10;
Console.Write($"Третья цифра числа {a} - {result}");
} else {
    Console.Write("NO");
}