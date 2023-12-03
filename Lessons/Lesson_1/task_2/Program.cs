// Программа приветсвия пользователя

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();
Console.Write("Привет, ");   
System.Console.Write(username);