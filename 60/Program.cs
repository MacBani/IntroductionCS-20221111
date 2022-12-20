// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами
int m = 4;
int n = 5;

int[,] doubleArray = new int[m, n];

fillArray(doubleArray);
showArray(doubleArray);

void fillArray(int[,] array)
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
            array[i, j] = rnd.Next(0, 9);
        }
    }
}

void showArray(int[,] array)
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