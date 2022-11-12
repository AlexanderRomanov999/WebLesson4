﻿System.Console.Write("m = ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n = ");
int n = Convert.ToInt32(System.Console.ReadLine());

int[,] matrix = GetRandomMatrix(m, n);

PrintMatrix(matrix);

CountAverage(matrix);

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

void CountAverage(int[,] matrix)
{
    double Sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Sum += matrix[i,j];
        }
        double avg = Math.Round(Sum / m, 1);
        System.Console.Write($"{avg}; ");
        Sum = avg = 0;
    }
}