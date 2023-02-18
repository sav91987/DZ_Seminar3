Console.WriteLine("Введите пятизначное число: ");
string Number = Console.ReadLine();
int RealNumber;
bool IsNumber = int.TryParse(Number, out RealNumber);
if (IsNumber)
{
    if (RealNumber < 0)
    {
        RealNumber = RealNumber * (-1);
    }
    if ((RealNumber >= 10000) && (RealNumber <= 99999))
    {
        if ((RealNumber / 10000) == (RealNumber % 10) && ((RealNumber / 1000) % 10) == ((RealNumber % 100) / 10))
        {
            Console.WriteLine($"Число {Number} является полиндромом");
        }
        else Console.WriteLine($"Число {Number} не является полиндромом");
    }
    else Console.WriteLine($"Число {Number} не является пятизначным. Введите корректное число");
}
else Console.WriteLine($"Число {Number} состоит не только из цифр");