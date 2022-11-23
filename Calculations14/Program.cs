//Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double a = ReadInt("Введите значение a -> ");
double b = ReadInt("Введите значение b -> ");
double srArif = (a + b) / 2;
double srGeom = Math.Sqrt(a * b);
Console.WriteLine($"Среднее арифметическое = {srArif}, а среднее геометрическое = {srGeom}");