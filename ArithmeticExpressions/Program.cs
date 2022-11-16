//Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
double a;
Console.WriteLine("Введите число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(a,2));