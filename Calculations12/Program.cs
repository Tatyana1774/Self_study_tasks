// Найти площадь кольца по заданным внешнему и внутреннему радиусам. S=π(R 2 -r 2 ) 
// где S – площадь кольца, R - внешний радиус кольца, r – внутренний радиус кольца, π – число Пи = 3,16
double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double R = ReadInt("Введите значение внешнего радиуса кольца -> ");
double r = ReadInt("Введите значение внутреннего радиуса кольца -> ");
double S = 3.14 * ((R * 2) - (r * 2));
Console.WriteLine($"Площадь кольца = {S} ");

