System.Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
double []arr = InitialArr(num);
double Max = FindMax(arr);
double Min = FindMin(arr);
PrintArray(arr);
System.Console.WriteLine("-> " + (Max-Min));

double[] InitialArr(int count)
{
    double[] arr = new double[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}
