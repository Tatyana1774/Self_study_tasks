/*Составить программу вывода на экран числа, вводимого с клавиатуры. 
После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».*/
Console.WriteLine("Введите любое число");
int mes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{mes} » — вот какое число Вы ввели");