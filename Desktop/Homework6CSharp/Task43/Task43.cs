double num1 = 0; double num2 = 0; double num3 = 0; double num4 = 0;
double X = CalculateCrossPointX(num1, num2, num3, num4);
double Y = CalculateCrossPointY(X, num2, num1);
System.Console.WriteLine("("+X+";"+Y+")");

double CalculateCrossPointX(double b1, double k1, double b2, double k2)
{
    Console.Write("b1: ");
    b1 = Convert.ToInt32(Console.ReadLine());
    num1 = b1;
    Console.Write("k1: ");
    k1 = Convert.ToInt32(Console.ReadLine());
    num2 = k1;
    Console.Write("b2: ");
    b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2: ");
    k2 = Convert.ToInt32(Console.ReadLine());
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CalculateCrossPointY(double x, double num2, double num1)
{
    double y =  num2 * x + num1;
    return y;
}