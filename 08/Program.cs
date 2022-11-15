// 8. Вывести на экран числа от -N до N
Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number >=0){
    for (int i = -number; i <= number; i++){
        Console.Write($"{i} ");
    }
} else{
    for (int i = -number; i >= number; i--){
        Console.Write($"{-i} ");
    }
}
