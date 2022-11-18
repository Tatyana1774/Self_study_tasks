//Известны объем и масса тела. Определить плотность материала этого тела. р = m/V; m — масса вещества [кг] V — объем вещества [м 3]

{
Console.WriteLine("Укажите массу вещества в кг  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите объём вещества в м3 ");
int v = Convert.ToInt32(Console.ReadLine());
int p = m / v;
Console.WriteLine($"Плотность материала этого тела = {p} кг/м3");
}