int[,] matrix = GetSpiralMatrix(4, 4);

PrintMatrix(matrix);

int[,] GetSpiralMatrix(int rows, int columns) // Решения в общем виде сделать не получилось
{
    int[,]matrix = new int[rows, columns];
    int k = 0;
    for (int j = 0; j < columns; j++)
    {
        k++;
        matrix [0, j] = k;
    }
    for (int i = 1; i < rows; i++)
    {
        k++;
        matrix [i, columns-1] = k;
    }
    for (int j = columns-2; j >= 0; j--)
    {
        k++;
        matrix [rows-1, j] = k;
    }
    for (int i = columns-2; i > 0; i--)
    {
        k++;
        matrix [i, 0] = k;
    }
    for (int j = 1; j < columns-1; j++)
    {
        k++;
        matrix [1, j] = k;
    }
    for (int i = 2; i < rows-1; i++)
    {
        k++;
        matrix [i, columns-2] = k;
    }
    for (int j = columns-3; j > 0; j--)
    {
        k++;
        matrix [rows-2, j] = k;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}