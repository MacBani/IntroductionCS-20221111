// 27.	Возведите число А в натуральную степень B используя цикл

while (true)
{
    Console.WriteLine("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{A} ^ {B} = {Math.Pow(A, B)}");
    Console.WriteLine("Если хотите закончить работу введите 0, для продолжения введите любое число: ");
    int controle = Convert.ToInt32(Console.ReadLine());
    if (controle == 0)
    {
        break;
    }

}
