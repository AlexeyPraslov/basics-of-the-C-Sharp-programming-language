// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя)

Console.WriteLine("введите число: "); //приглашает пользователя ко вводу
int number = Convert.ToInt32(Console.ReadLine()); //принимает число от пользователя и помещает в переменную number

int square = number * number; //вычисляет квадрат number и записывает его в square
System.Console.WriteLine($"квадрат числа {number} равен {square}"); //вывод