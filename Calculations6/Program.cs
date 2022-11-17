//Дан радиус окружности. Найти длину окружности и площадь круга. площадь круга S=πR² 2 длина окружности P=2πR
{
Console.WriteLine("Укажи радиус окружности  ");
double r = double.Parse(Console.ReadLine());
const double P = 3.14;
double square = Math.Pow(r, 2) * P;
double lenghtSirkl = 2 * r * P;
Console.WriteLine("Длина окружности равна {0} м., а площаь равна {1} м2", lenghtSirkl, square);
Console.WriteLine(new string('-', 50));
}