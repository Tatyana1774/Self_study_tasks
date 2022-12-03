//Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?

double monitor = 750;
double sys = 2000;
double keyboard = 270;
double mouse = 170;

double x = ReadInt("Укажите количество компьютеров: ");

double sum = x * (monitor + sys + keyboard + mouse);
Console.WriteLine("Стоимость всей покупки = {0}", sum);








double ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}