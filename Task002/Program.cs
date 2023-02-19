Console.WriteLine("Введите число: ");
string Str = Console.ReadLine();

int Number = Convert.ToInt32(Str);

if (Number < 0) Number = Number * (-1);

if (Number < 100) Console.WriteLine("Число двузначное: середины нет");
else
{
    int NumberSaved = Number;
    int count = 0;
    int Max = Number % 10;
    int Min = Number % 10;
    while (Number > 0)
    {
        if ((Number % 10) > Max)
        {
            Max = Number % 10;
        }
        else if ((Number % 10) < Min)
        {
            Min = Number % 10;
        }
        Number /= 10;
        count++;
    }

    if ((count % 2) == 0)
    {
        Console.WriteLine("У данного числа нет середины");
    }
    else
    {
        int SrNumber = 0;
        for (int i = 1; i <= (count / 2); i++)
        {
            NumberSaved /= 10;
            SrNumber = NumberSaved % 10;
        }
        if ((Max - Min) == SrNumber)
        {
            Console.WriteLine("Интересное");
        }
        else Console.WriteLine("Не интересное");
    }
}