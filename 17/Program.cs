//17.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number}ой день недели является выходным днём");
    }
    else
    {
        Console.WriteLine("Данный день недели является будним днём");
    }
}

