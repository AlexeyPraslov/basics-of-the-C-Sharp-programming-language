// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) // если наше число делится на 7 и 23 без остатка
{
    System.Console.WriteLine($"{number} кратное 7 и 23"); //то выводим это
}
else // во всех остальных случаях выводим это
{
    System.Console.WriteLine($"{number} не кратное 7 и 23");
}