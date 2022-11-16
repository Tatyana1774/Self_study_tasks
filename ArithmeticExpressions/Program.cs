//Вывести на экран число  с точностью до сотых
double a;
Console.WriteLine("Введите число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(a,2));