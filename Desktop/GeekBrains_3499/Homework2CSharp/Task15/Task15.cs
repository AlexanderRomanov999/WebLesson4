int num = 0;
int number = GetNumber(num);
Print(number);

int GetNumber(int number)
{
    Console.WriteLine("Введите цифру, обозначающую день недели");
    while (true) {
        number = int.Parse(Console.ReadLine());
        if (number>7 || number<1) {
            Console.WriteLine("Нужно ввести цифру от 1 до 7!");
        }
        else {
            return number;
        }
    }
}

void Print (int num)
{
    if (num==6 || num==7) {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }
}