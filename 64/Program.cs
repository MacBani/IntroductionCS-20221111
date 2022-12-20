// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] doubleArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
showArray(doubleArray);
changeEvenNumber(doubleArray);
System.Console.WriteLine();
showArray(doubleArray);

int[,] changeEvenNumber(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 & j % 2 == 0)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);

            }
        }

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