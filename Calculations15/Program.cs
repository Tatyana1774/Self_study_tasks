//Даны основания и высота равнобедренной трапеции. Найти ее периметр. P = a + b + c + d
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int a = ReadInt("Введите значение a -> ");
int b = ReadInt("Введите значение b -> ");
int c = ReadInt("Введите значение c -> ");
int d = ReadInt("Введите значение d -> ");
int P = a + b + c + d;
Console.WriteLine($"Периметр равнобедренной трапеции = {P} ");