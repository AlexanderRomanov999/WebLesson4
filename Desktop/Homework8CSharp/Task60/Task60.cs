System.Console.Write("l = ");
int l = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("m = ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n = ");
int n = Convert.ToInt32(System.Console.ReadLine());

int[,,] matrix = GetRandomMatrix(l, m, n);

PrintMatrix(matrix);

int[,,] GetRandomMatrix(int rows, int columns, int thirdDimension, int maxValue = 100, int minValue = 10)
{
    int[,,]matrix = new int[rows, columns, thirdDimension];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < thirdDimension; k++)
            {
                /*do
                {
                    matrix[i,j,k] = random.Next(minValue, maxValue + 1);
                }
                while (Check(i, j, k, matrix, matrix[i,j,k]) == false);*/
                matrix[i,j,k] = random.Next(minValue, maxValue + 1);
            }
        }
    }
    return matrix;
}

/*bool Check(int rows, int columns, int thirdDimension, int[,,]matrix, int digit)  Метод работает неправильно, рабочего решения придумать не получилось
{
    bool Unic = true;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < thirdDimension; k++)
            {
                if (matrix[i,j,k] == digit)
                {
                    Unic = false;
                }
                else 
                {
                    Unic = true;
                }
            }
        }
    }
    return Unic;
}*/

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}