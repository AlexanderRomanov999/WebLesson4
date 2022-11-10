System.Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
double []arr = InitialArr(num);
int sum = CountPositive(arr);
PrintArray(arr);
System.Console.WriteLine("-> " + sum);

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

int CountPositive(double[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum ++;
        }
    }
    return sum;
}