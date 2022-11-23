//Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.
double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double a = ReadInt("Введите значение a -> ");
double b = ReadInt("Введите значение b -> ");
if(a < 0)
{
    a *= -1;
}
else if(b < 0)
{
    b*= -1;
}
double srArif = (a + b) / 2;
double srGeom = Math.Round(Math.Sqrt(a * b), 2);
Console.WriteLine($"Среднее арифметическое = {srArif}, а среднее геометрическое = {srGeom}");