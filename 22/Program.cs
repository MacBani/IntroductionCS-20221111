// 22.	Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
int length = a;
int count = 0;
while (length != 0)
{
    length = length / 10;
    count++;
}

if (count == 5)
{
    int left = a / 1000;
    //Console.WriteLine(left);

    int right = a % 100;
    //Console.WriteLine(right);

    String right_1 = Convert.ToString(right);
    //Console.WriteLine(right_1);

    right_1 = Convert.ToString(Convert.ToInt32(right_1) % 10) + Convert.ToString(Convert.ToInt32(right_1) / 10);
    //Console.WriteLine(right_1);

    right = Convert.ToInt32(right_1);
    //Console.WriteLine(right);


    if (left == right)
    {
        Console.WriteLine($"Число {a} - палиндром");
    }
    else { Console.WriteLine($"Число {a} - НЕ палиндром"); }
}

else { Console.WriteLine("Число не пятизначное"); }

