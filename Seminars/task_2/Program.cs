// напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго
Console.WriteLine("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.Write ($"число {num1} является квадратом числа {num2}");
}
else
{
    System.Console.Write($"число {num1} не является квадратом числа {num2}");
}