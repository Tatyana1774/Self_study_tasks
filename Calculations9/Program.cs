/* Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве. 
P = A / S: P - плотность населения,  A - количество жителей, S - площадь территории */
{
Console.WriteLine("Укажите количество жителей  ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите площадь территории государства в м2 ");
double S = Convert.ToDouble(Console.ReadLine());
double P = A / S;
Console.WriteLine($"Плотность населения = {P} на м2");
}