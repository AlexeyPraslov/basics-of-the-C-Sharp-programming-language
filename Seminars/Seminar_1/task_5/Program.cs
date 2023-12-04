// напишите программу, которая принимает трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 1000)
{
    System.Console.WriteLine("некорректный ввод");
    return;
}
Console.WriteLine(number % 10);

