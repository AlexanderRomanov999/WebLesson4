int num = 0;
int number = GetNumber(num);
int Sum = GetSumOfDigits(number);
PrintSumOfDigits(Sum);

int GetNumber(int number)
{
    Console.WriteLine("Введите число");
    number = int.Parse(Console.ReadLine());
    return number;
}

int GetSumOfDigits(int num)
{
    int Sum = 0;
    int temp = num;
    while (num > 0)
    {
        temp = num;
        num %= 10;
        Sum += num;
        num = temp;
        num /= 10;
    }
    return Sum;
}

void PrintSumOfDigits (int Sum)
{
    Console.WriteLine(Sum);
}