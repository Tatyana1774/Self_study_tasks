//Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
int a4 = new Random().Next(0, 50);
int b4 = new Random().Next(0, 10);
int c4 = new Random().Next(-10, 10);
Console.WriteLine($"{a4}  {b4}  {c4}");