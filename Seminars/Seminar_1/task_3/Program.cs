// напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.WriteLine("введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    System.Console.WriteLine("понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("среда");
}
else if (day == 4)
{
    System.Console.WriteLine("четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("пятница");
}
else if (day == 6)
{
    System.Console.WriteLine("суббота");
}
else if (day == 7)
{
    System.Console.WriteLine("воскресенье");
}
else
{
    System.Console.WriteLine("некорректный ввод");
}