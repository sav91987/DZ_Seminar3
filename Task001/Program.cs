Console.WriteLine("Введите сумму вклада: ");
int Sum = Convert.ToInt32(Console.ReadLine());

double ResultSum = Sum;

if ((Sum <= 100) && (Sum > 0))
{
    ResultSum = Sum + Sum * 0.05;
    Console.WriteLine(ResultSum);
}
else if ((Sum > 100) && (Sum <= 200))
{
    ResultSum = Sum + Sum * 0.07;
    Console.WriteLine(ResultSum);
}
else if (Sum > 200)
{
    ResultSum = Sum + Sum * 0.1;
    Console.WriteLine(ResultSum);
}
else Console.WriteLine("Введите корректную сумму вклада");
