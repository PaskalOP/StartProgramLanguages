Console.WriteLine("Введите число, которому соответсвует день недели: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine(" Опять ПОНЕДЕЛЬНИК ((( ");
}
else if (day == "2")
{
    Console.WriteLine(" Уже ВТОРНИК ( ");
}
else if (day == "3")
{
    Console.WriteLine(" Среда - маленькая пятница ");
}
else if (day == "4")
{
    Console.WriteLine(" Сегодня четверг - скоро пятница");
}
else if (day == "5")
{
    Console.WriteLine(" УРА!!! ПЯТНИЦА!");
}
else if (day == "6")
{
    Console.WriteLine(" Суббота ");
}
else if (day == "7")
{
    Console.WriteLine(" Воскресенье - готовься! Завтра ПОНЕДЕЛЬНИК");
}
else
{
    Console.WriteLine(" Это вообще не день недели ");
}

