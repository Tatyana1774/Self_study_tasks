// Даны основания и высота равнобедренной трапеции. Найти периметр трапеции. P=a+b+c+d
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите значение стороны a -> ");
int b = ReadInt("Введите значение стороны b -> ");
int c = ReadInt("Введите значение стороны c -> ");
int d = ReadInt("Введите значение стороны d -> ");
int P = a + b + c + d;
Console.WriteLine($"Периметр трапеции = {P}");