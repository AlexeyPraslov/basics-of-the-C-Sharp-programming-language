// Программа которая принимает на вход два числа и выводит, 
//является ли второе число кратное первому, если нет, то программа 
//выводит остаток от деления

System.Console.WriteLine("Введите двухзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10 || num > 99)
{
    System.Console.WriteLine("Вы ввели некорректные данные");
    return;
}

int firstNum = num / 10;
int secondNum = num % 10;
int ost = firstNum % secondNum;

if (firstNum % secondNum == 0)
{
    System.Console.WriteLine($"{firstNum} является кратным {secondNum}");
}
else
{
    System.Console.WriteLine(ost);
}


//________________________________________________________________________________

// второй вариант решения

// System.Console.WriteLine("введите первое число: ");
// int num1 = Conver.ToInt32(Console.ReadLine());

// System.Console.WriteLine("введите второе число: ");
// int num2 = Conver.ToInt32(Console.ReadLine());

// int mult = num1 % num2;

// if(mult == 0)
// System.Console.WriteLine("yes");
// else
// System.Console.WriteLine($"no, ostatok {mult}");