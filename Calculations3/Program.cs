/*Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
h=AB; OA=OG=R - радиус Земли; BG - расстояние до горизонта; BG перпендикулярна OG как касательная к окружности*/
double r = 6350, x;

Console.Write("Введите высоту h= ");
double h = Convert.ToDouble(Console.ReadLine());

if (h>0)
{
  x = Convert.ToDouble( Math.Sqrt(Math.Pow(r + h, 2) - (r * r)));
   
  Console.WriteLine($"Расстояние до линии горизонта = {x}");  
}
else
{
  Console.WriteLine("Высота должна быть >0");
}
