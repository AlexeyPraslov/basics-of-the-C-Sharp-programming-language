// программа которая выводит третью цифру с конца, или пишет, что третей цифры нет

System.Console.WriteLine("введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
    System.Console.WriteLine("число не трехзначное");
    return;
}

int lastNum = num % 10;

System.Console.WriteLine($"последняя цифра числа {num} - {lastNum}");
