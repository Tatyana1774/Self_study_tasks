//Дана сторона квадрата. Найти его периметр. 
Console.WriteLine("Введите длину стороны квадрата ");
float L = Convert.ToSingle(Console.ReadLine());
if(L > 0)
{
    float p = L * 4;
    Console.WriteLine("\n Периметр квадрата = {0} .\n", p);
return;
}
else
Console.Write("Введено не верное значение.");
Console.ReadKey();

