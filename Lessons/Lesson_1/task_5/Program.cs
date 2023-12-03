// программа приветсвия пользователя

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");//меняет кодировку с ютф8 на ютф 16
System.Console.WriteLine("введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "таня")//туловер - принимает любой регитр букв
{
    System.Console.WriteLine("Ура, это же Таня");
}
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}