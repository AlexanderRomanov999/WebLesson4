string[] InputArray(string[] Array, int n) {
    Console.WriteLine("Введите строки");
    for (int i = 0; i < n; i++)
    {
        Array[i] = Console.ReadLine();
    }
    return Array;
}

int FindStringsLessThanN (string[] Array1, int n, int Length) {
    int Count = 0;
    for (int i = 0; i < n; i++)
    {
        if (Array1[i].Length <= Length)
        {
            Count++;
        }
    }
    return Count;
}

string[] FillFinalArray (string[] Array1, string[] Array, int n, int Length) {
    for (int i = 0, j = 0; i < n; i++)
    {
        if (Array1[i].Length <= Length)
        {
            Array[j] = Array1[i];
            j++;
        }
    }
    return Array;
}

void PrintFinalArray(string[] Array, int Count) {
    Console.WriteLine();
    for (int j = 0; j < Count; j++)
    {
        Console.Write(Array[j] + " ");      
    }
}

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
string[] Array1 = new string[n];
string[] Array2 = new string[n];
Array1 = InputArray(Array1, n);
int Count = FindStringsLessThanN (Array1, n, 3);
Array2 = FillFinalArray (Array1, Array2, n, 3);
PrintFinalArray(Array2, Count);