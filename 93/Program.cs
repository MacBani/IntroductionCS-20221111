/* Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
70 61 46 69
61 119 92 76
46 92 100 88
69 76 88 114 */


int[,] Array1 = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] Array2 = { { 1, 5, 8, 5 }, { 4, 9, 4, 2 }, { 7, 2, 2, 6 }, { 2, 3, 4, 7 } };
int rows1 = Array1.GetUpperBound(0) + 1;
int columns1 = Array1.Length / rows1;

int rows2 = Array2.GetUpperBound(0) + 1;
int columns2 = Array2.Length / rows2;

int[,] ArrayResult = new int[rows1, columns2];

if (columns1 == rows2)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns2; k++)
            {
                ArrayResult[i, j] += Array1[i, k] * Array2[k, j];
            }

        }
    }
}
else
{
    Console.WriteLine("Число столбцов первой матрицы должно совпадать с числом строк второй матрицы");
}
showArray(Array1);
Console.WriteLine();
showArray(Array2);
Console.WriteLine();
showArray(ArrayResult);

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