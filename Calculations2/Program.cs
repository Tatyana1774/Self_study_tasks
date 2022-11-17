//Дан радиус окружности. Найти ее диаметр. D = 2 × R
Console.WriteLine("Введите радиус окружности");
float r = Convert.ToSingle(Console.ReadLine());
if(r > 0)
{
    float  D = 2 * r;
    Console.WriteLine($"Диаметр окружности = {D} .\n", r);
return;
}
else
Console.Write("Введено не верное значение.");
Console.ReadKey();