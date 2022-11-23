//Даны катеты прямоугольного треугольника. Найти его гипотенузу. c = √ (a 2+ b 2), где a - катет; b - катет; c - гипотенуза.
double a = ReadInt("Введите значение первого катета a ");
double b = ReadInt("Введите значение первого катета b ");
double c = Math.Sqrt((a * 2) + (b * 2));
Console.WriteLine($"Гипотенуза треугольника = {c}");


double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}