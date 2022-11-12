System.Console.Write("m1 = ");
int m1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n1 = ");
int n1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("m2 = ");
int m2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n2 = ");
int n2 = Convert.ToInt32(System.Console.ReadLine());

int[,] matrix1 = GetRandomMatrix(m1, n1);

int[,] matrix2 = GetRandomMatrix(m2, n2);

PrintMatrix(matrix1);

System.Console.WriteLine();

PrintMatrix(matrix2);

System.Console.WriteLine();

int[,] matrix3 = MatrixesMultiply(matrix1, matrix2);

PrintMatrix(matrix3);

int[,] GetRandomMatrix(int rows, int columns, int maxValue = 10, int minValue = 0)
{
    int[,]matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(minValue, maxValue + 1);
        }
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

int[,] MatrixesMultiply(int[,] matrix1, int[,] matrix2)
{
    int [,] resultMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return resultMatrix;
}