// программа которая принимает два числа на трезке от 10 до 99 и показывает наибольшую цифру числа

System.Console.WriteLine("введите двухзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 10 || number > 99)
{
    System.Console.WriteLine("Вы ввели не двухзначное число!");
    return;
}

int firstNum = number / 10; //получаем первую цифру
int secondNum = number % 10; // получаем последнюю цифру

if (firstNum > secondNum)
{
    System.Console.WriteLine($"наибольшая цифра числа {number} -> {firstNum}");
}
else
{
     System.Console.WriteLine($"наибольшая цифра числа {number} -> {secondNum}");
}