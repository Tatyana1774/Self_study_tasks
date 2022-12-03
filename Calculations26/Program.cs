//Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.
int averageTanya = 0;
int averageMitya = 0;
Console.WriteLine("Сколько лет Тане ?: ");

int ageTanya = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
Console.Write("Сколько лет Мите ?: ");
int ageMitya = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
if ((ageTanya > 0) & (ageMitya > 0))
{
    int average = ((ageTanya + ageMitya) / 2);
    if (average > ageTanya)
    {
        averageTanya = average - ageTanya;
        Console.WriteLine();
        if (averageTanya <= 4)
        {
            if (averageTanya == 1)
            {
                Console.WriteLine("Возраст Тани меньше среднего возраста на {0}", averageTanya);
            }
            else
            {
                Console.WriteLine("Возраст Тани меньше среднего возраста на {0}", averageTanya);
            }
        }
        else
        {
            Console.WriteLine("Возраст Тани меньше среднего возраста на {0}", averageTanya);
        }
    }
    else
    {
        averageTanya = ageTanya - average;
        Console.WriteLine();
        if (averageTanya < ageMitya)
        {
            averageMitya = average - ageMitya;
            Console.WriteLine();
            if (averageMitya <= 4)
            {
                if (averageMitya == 1)
                {
                    Console.WriteLine("Возраст Мити меньше среднего возраста на {0}", averageMitya);
                }
                else
                {
                    Console.WriteLine("Возраст Мити меньше среднего возраста на {0}", averageMitya);
                }
            }
            else
            {
                Console.WriteLine("Возраст Мити меньше среднего возраста на {0}", averageMitya);
            }
        }
        Console.WriteLine();
    }
}
/*
int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine);
}*/