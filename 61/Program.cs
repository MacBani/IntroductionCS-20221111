// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами
int m = 4;
int n = 5;

double[,] doubleArray = new double[m, n];

fillArray(doubleArray);
showArray(doubleArray);

void fillArray(double[,] array)
{
    Random rnd = new Random();
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;        // количество столбцов
                                              // или так
                                              // int columns = numbers.GetUpperBound(1) + 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble();
        }
    }
}

void showArray(double[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}