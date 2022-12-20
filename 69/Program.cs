// 69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int[,] doubleArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
showArray(doubleArray);
sortRowsAraay(doubleArray);
Console.WriteLine();
showArray(doubleArray);

int[,] sortRowsAraay(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int tmp = 0;
    int count = 0;

    for (int i = 0; i < rows; i++)
    {
        while (count < columns)
        {
            for (int j = 1; j < columns; j++)
            {
                if (array[i, j] < array[i, j - 1])
                {
                    tmp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = tmp;
                }
            }
            count++;
        }
        count = 0;

    }
    return array;
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
