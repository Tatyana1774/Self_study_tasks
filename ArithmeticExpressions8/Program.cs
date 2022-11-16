/* Составить программу вывода на экран в одну строку четырех
любых чисел с одним пробелом между ними.*/
int a = new Random().Next(0, 1000);
int b = new Random().Next(0, 500);
int c = new Random().Next(-100, 100);
int d = new Random().Next(-1000, 0);
Console.WriteLine($"{a} {b} {c} {d}");