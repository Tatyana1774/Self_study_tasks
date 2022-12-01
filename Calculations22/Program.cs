// Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.  P ABC=| AB| + |BC| + |CA|. 
//S = 0.5 * (x2 - x1 )(y3 - y1 ) - (x3 - x1 )(y2 - y1)
double x1 = ReadInt("Введите координаты первой точки Х: ");
double x2 = ReadInt("Введите координаты второй точки Х: ");
double x3 = ReadInt("Введите координаты третьей точки Х: ");
double y1 = ReadInt("Введите координаты первой точки Y: ");
double y2 = ReadInt("Введите координаты второй точки Y: ");
double y3 = ReadInt("Введите координаты третьей точки Y: ");
double AB = Math.Sqrt(((x1 * x1) + (y1*y1)));
double BC = Math.Sqrt(((x2 * x2) + (y2*y2)));
double CA = Math.Sqrt(((x3 * x3) + (y3*y3)));
double P = AB + BC + CA;
double S = 0.5 * (x2 - x1) * (y3 - y1) * (x3 - x1) * (y2 - y1);
Console.WriteLine($"Периметр треугольника равен = {P}, а его площадь = {S}");





double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}