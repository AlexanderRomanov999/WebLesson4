System.Console.WriteLine("Введите размерность массива");
int num = Convert.ToInt32(Console.ReadLine());
int []arr = InitialArr(num);
int sum = CheckIsEven(arr);
PrintArray(arr);
System.Console.WriteLine("-> " + sum);

int[] InitialArr(int count)
{
    Random rand = new Random();
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = rand.Next(100, 1000);
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

int CheckIsEven (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            sum++;         
        }      
    }
    return sum;
}