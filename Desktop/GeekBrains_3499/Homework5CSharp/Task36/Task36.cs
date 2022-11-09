System.Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int []arr = InitialArr(num);
int Sum = CountOddPositions(arr);
PrintArray(arr);
System.Console.WriteLine("-> " + Sum);

int[] InitialArr(int count)
{
    Random rand = new Random();
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = rand.Next(-100, 101);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int CountOddPositions (int[] arr)
{
    int Sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) 
        {
            Sum+=arr[i];         
        }      
    }
    return Sum;
}