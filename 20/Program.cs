//20.	Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Задайте координаты точки: X = ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write(" Y = ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится в четвёртой четверти");
}
