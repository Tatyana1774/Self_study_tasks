//  Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции. S=​a*b / sin(α)​​​∘ //NaN или S = (a​2​​−b​2​​)⋅tan(α)​∘​​​​ / 4
double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double a = ReadInt("Введите значение большего основания a -> ");
double b = ReadInt("Введите значение меньшего основания b -> ");
double alfa = ReadInt("Введите значение угла при большем основании трапеции -> ");
double radians = alfa * (Math.PI / 180);
double S = (a * b) / Math.Sin(radians);
Console.WriteLine($"Площадь трапеции = {S}"); //a=10 b=5 alfa=60 S=57.735
/*double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double a = ReadInt("Введите значение большего основания a -> ");
double b = ReadInt("Введите значение меньшего основания b -> ");
double alfa = ReadInt("Введите значение угла при большем основании трапеции -> ");
double radians = alfa * (Math.PI / 180);
double S = (((a * a) - (b * b)) * Math.Tan(radians)) / 4;
Console.WriteLine($"Площадь трапеции = {S}"); //a=10 b=5 alfa=60 S=32.476*/

/*double bigside, smallside;
double angle;
double area;

while (true)
{
Console.Write("Введите значение большего основания трапеции:");
bigside = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите значение меньшего основания трапеции:");
smallside = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите значение угла при большем основании трапеции:");
angle = double.Parse(Console.ReadLine());
Console.WriteLine();

if (bigside <= smallside)
Console.WriteLine("Ошибка! Введите значения снова.");
else
break;
}

area = (((bigside * bigside) - (smallside * smallside)) * Math.Tan(angle)) / 4;

Console.WriteLine("Площадь трапеции = {0:0.00} ", area);
Console.ReadLine();*/