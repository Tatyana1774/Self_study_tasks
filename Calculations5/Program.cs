// Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности. V=a³ S бок = 4a 2
{
    Console.Write("длина ребра куба равна   ");
    int cubeEdge = int.Parse(Console.ReadLine());
    double value = Math.Pow(cubeEdge, 3);
    double square = Math.Pow(cubeEdge, 2);
    Console.WriteLine("объем куба равен {0} м3, а площадь боковой поверхности равна {1} м2", value, square);
    Console.WriteLine(new string('-', 50));
}