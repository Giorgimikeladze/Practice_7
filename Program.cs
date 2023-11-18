

int numb;
Console.Write("Enter integer value: ");
bool is_parsed = Int32.TryParse(Console.ReadLine(), out numb);

if (is_parsed && numb >= 1)
{
    int num1 = 0;
    int num2 = 1;
    int num3;
    Console.Write($"{num1} {num2} ");

    for (int i = 2; i <= numb; ++i)
    {
        num3 = num1 + num2;
        Console.Write($"{num3} ");
        num1 = num2;
        num2 = num3;
    }
}
else {
    Console.WriteLine("invalid value!!!");

}