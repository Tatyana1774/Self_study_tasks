//Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
{
Console.WriteLine("укажи два целых числа через ENTER   ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int averageArifm = (a + b) / 2;
double averageGeom = Math.Sqrt(a * b);
Console.WriteLine("Среднее арифмитическое {0} и {1} = {2}, а геометрическое {3}", a, b, averageArifm, averageGeom);
Console.WriteLine(new string('-', 50));

}