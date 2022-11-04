int num = 0;
int number = GetNumber(num);
int SecondDigit = GetSecondDigit(number);
PrintSecondDigit(SecondDigit);

int GetNumber(int number)
{
    Console.WriteLine("Введите трехзначное число");
    while (true) {
        number = int.Parse(Console.ReadLine());
        if ((number>-100 && number<100) || number>999 || number<-999) {
            Console.WriteLine("Нужно ввести трехзначное число!");
        }
        else {
            return number;
        }
    }
}

int GetSecondDigit(int num)
{
    int SecondDigit = (num/10)%10;
    return SecondDigit;
}

void PrintSecondDigit (int SecondDigit)
{
    Console.WriteLine(SecondDigit);
}