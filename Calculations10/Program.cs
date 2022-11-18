//Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).
double a, b;
double x;
while (true)
{
Console.Write("Введите значение a: ");
a = double.Parse(Console.ReadLine());
if (a > 0)
break;
else if(a == 0)
Console.WriteLine("Неверное значение а, повторите попытку ввода! ");
else if(a<0)
break;
}

Console.Write("Введите значение b: ");
b = double.Parse(Console.ReadLine());

x = (double) ((b / a) * (-1));

Console.WriteLine("х равен = {0:0.00}", x);
Console.ReadLine();