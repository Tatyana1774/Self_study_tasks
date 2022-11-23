// Даны катеты прямоугольного треугольника. Найти его периметр. P=a+b+c
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите значение катета a -> ");
int b = ReadInt("Введите значение катета b -> ");
int c = ReadInt("Введите значение катета c -> ");
int P = a + b + c;
Console.WriteLine($"Периметр треугольника = {P}");