// напишите программу которая принимае на вход трехзначное 
// число и удаляет вторую цифру этого числа
// a = 256 = 26

System.Console.WriteLine("Введите трехзнаное чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int first = number / 100; //получаем первую цифру числа
    int second = number % 10; //получаем третью цифру числа
    System.Console.WriteLine(first + " " + second);
}
else
{
    System.Console.WriteLine("введено не трехзначное число");
}
