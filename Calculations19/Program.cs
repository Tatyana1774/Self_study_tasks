//  Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int X1 = ReadInt("Введите координату первой точки Х1 ");
int Y1 = ReadInt("Введите координату точки первой Y1 ");
int X2 = ReadInt("Введите координату первой точки Х2 ");
int Y2 = ReadInt("Введите координату точки первой Y2 ");

int x = X2 - X1;
int y = Y2 - Y1;
int d = ((x * x)+ (y * y));
double distance = Math.Sqrt(d);

Console.WriteLine($" Расстояние между точками XY = {distance}");