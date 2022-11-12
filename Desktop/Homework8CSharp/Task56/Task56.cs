System.Console.Write("m = ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n = ");
int n = Convert.ToInt32(System.Console.ReadLine());

int[,] matrix = GetRandomMatrix(m, n);

PrintMatrix(matrix);

int minrow = FindMinimalRow(matrix);

System.Console.WriteLine($"{minrow} строка");

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

int FindMinimalRow(int[,] matrix)
{
    int minSum = 100000;
    int Sum = 0;
    int minIndex = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i,j];
        }
        if (Sum < minSum)
        {  
            minSum = Sum;
            minIndex = i+1;
        }
        Sum = 0;
     }
     return minIndex;
}