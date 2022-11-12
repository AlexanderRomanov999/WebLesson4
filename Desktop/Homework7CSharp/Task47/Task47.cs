System.Console.Write("m = ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n = ");
int n = Convert.ToInt32(System.Console.ReadLine());

double[,] matrix = GetRandomMatrix(m, n);

printMatrix(matrix);

double[,] GetRandomMatrix(int rows, int columns, int maxValue = 100, int minValue = -100)
{
    double[,]matrix = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = random.Next(minValue, maxValue + 1) / 10.0;
        }
    }
    return matrix;
}

void printMatrix(double[,] matrix)
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
