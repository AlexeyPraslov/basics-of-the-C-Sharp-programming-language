// напишите программу которая принимает на вход трехзначное число и 
// возводит второе число в степень равную третьему числу

System.Console.WriteLine("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    System.Console.WriteLine("некорректный ввод");
    return;
}

int third = number % 10;
int second = number / 10 % 10;
int pow = 1;

while(third != 0)
{
    pow = pow * second;
    --third; // third = third - 1
}

System.Console.WriteLine($"результат возведения в степень {pow}");