/*Составить программу:
а) вычисления значения функции y=7x2+3x+6 при любом значении x;
б) вычисления значения функции x=12a2+7a+12 при любом значении а.*/

Random random = new Random();

double y, x1;
double x = random.Next(-100, 100);
double a = random.Next(-100, 100);
y = ((7 * Math.Pow(x, 2)) + (3 * x) + 6);
x1 = ((12 * Math.Pow(a, 2)) + (7 * a) + 12);
Console.WriteLine($"((7 * {Math.Pow(x, 2)}) + (3 * {x}) + 6)= {y}");
Console.WriteLine($"((12 * {Math.Pow(a, 2)}) + (7 * {a}) + 12)= {x1}");
Console.ReadKey();