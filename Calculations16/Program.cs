//Даны стороны прямоугольника. Найти его периметр и длину диагонали. P=2(a+b);  d = √ (a 2+ b 2), a, b — стороны прямоугольника; d — диаметр прямоугольника.
double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double a = ReadInt("Введите значение стороны a -> ");
double b = ReadInt("Введите значение стороны b -> ");
double P = 2 * (a + b);
double d = Math.Sqrt((a * 2) + (b * 2));
Console.WriteLine($"Периметр прямоугольника = {P}, а диаметр = {d}");