// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//     Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.


int[,] doubleArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
showArray(doubleArray);
changeEvenNumber(doubleArray);
showArray(doubleArray);

int[,] changeEvenNumber(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = -array[i, j];
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