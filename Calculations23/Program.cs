//  Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.
double x1 = ReadInt("введите координаты первой точки X: ");
double x2 = ReadInt("введите координаты второй точки X: ");
double x3 = ReadInt("введите координаты третьей точки X: ");
double x4 = ReadInt("введите координаты четвертой точки X: ");
double y1 = ReadInt("введите координаты первой точки Y: ");
double y2 = ReadInt("введите координаты второй точки Y: ");
double y3 = ReadInt("введите координаты третьей точки Y: ");
double y4 = ReadInt("введите координаты четвертой точки Y: ");
double a = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
double b = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
double c = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
double d = Math.Sqrt(Math.Pow((x4 - x1), 2) + Math.Pow((y4 - y1), 2));
double e = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
double P1 = (a + b + e) / 2;
double S1 = Math.Sqrt((P1 * (P1 - a)) * (P1 - b) * (P1 - e));
double P2 = (c + d + e) / 2;
double S2 = Math.Sqrt((P2 * (P2 - c)) * (P2 - d) * (P2 - e));
double SS = S1 + S2;
double sumS = S1 + S2 + SS;
Console.WriteLine("площадь первого треугольника: {0}", S1);
Console.WriteLine("площадь второго треугольника: {0}", S2);
Console.WriteLine("площадь выпуклого квадрата: {0}", SS);
Console.WriteLine("общая площадь выпуклого прямоугольника: {0}", sumS);
Console.ReadLine();



double ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}