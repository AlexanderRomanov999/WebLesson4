int A = 0;
int B = 0;
int Power = Exponentiation(A, B);
PrintResult(Power);

int Exponentiation(int num, int num2)
{
    Console.WriteLine("Введите число A");
    num = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B");
    num2 = int.Parse(Console.ReadLine());
    int Pow = 1;
    for (int i = 0; i < num2; i++)
    {
        Pow *= num;      
    }
    return Pow;
}

void PrintResult(int Pow)
{
    Console.WriteLine(Pow);
}