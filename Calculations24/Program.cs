//Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

double candiesKg = 15;
double cookieKg = 20;
double appleKg = 17;

double x = ReadInt("Укажите вес конфет в кг: ");
double y = ReadInt("Укажите вес печеньяв кг: ");
double z = ReadInt("Укажите вес яблок в кг: ");

double sum = (x * candiesKg) + (y * cookieKg) + (z * appleKg);
Console.WriteLine("Стоимость всей покупки = {0}", sum);








double ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}