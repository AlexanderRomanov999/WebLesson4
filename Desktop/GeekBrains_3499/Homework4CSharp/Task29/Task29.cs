int size = 8;

int[] arr = GetRandomArray(size, 1, 101);

PrintArray(arr);

int[] GetRandomArray(int size, int begin, int last) 
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i=0; i<size; i++)
    {
        arr[i]= random.Next(begin, last);
    } 

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i=0; i<size; i++)
    {
        if (i==size-1) {
             System.Console.Write(arr[i]);   
        }
        else {
            System.Console.Write(arr[i]+", ");
        }
    }
}