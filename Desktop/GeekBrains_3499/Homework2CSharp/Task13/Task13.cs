int num = 0;
int number = GetNumber(num);
int ThirdDigit = GetThirdDigit(number);
PrintThirdDigit(ThirdDigit);

int GetNumber(int number)
{
    Console.WriteLine("Введите число");
    number = int.Parse(Console.ReadLine());
    return number;
}

int GetThirdDigit(int num)
{
    int ThirdDigit = 0;
    if(num>-100 && num<100) {
        ThirdDigit = -1;
    }
    else {
        if (num >= 100) {
            while (num >= 1000)
            {
                num /= 10;
            }
            ThirdDigit = num%10;
        }
    }
    return ThirdDigit;
}

void PrintThirdDigit (int ThirdDigit)
{
    if (ThirdDigit>=0 && ThirdDigit<=9) {
        Console.WriteLine(ThirdDigit);    
    }
    else {
        Console.WriteLine("Третьей цифры нет");
    } 
}