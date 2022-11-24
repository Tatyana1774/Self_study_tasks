//Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.
double ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double num1 = ReadInt("Введите первое число -> ");
double num2 = ReadInt("Введите второе число -> ");
double sum = num1 + num2;
double diff = num1 - num2;
double comp = num1 * num2;
double del = num1 / num2;
Console.WriteLine($"Итак, сумма = {sum}, разность = {diff}, произведение = {comp}, частное = {del}");