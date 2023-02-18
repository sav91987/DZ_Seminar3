Console.Write("Введите координату точки A по оси Х: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Y: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Z: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси Х: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine(Math.Round(result, 2));