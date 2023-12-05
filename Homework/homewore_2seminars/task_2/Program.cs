// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

System.Console.WriteLine("Введите координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.Write("Вы находитесь в первой четверти");
}
else if(x < 0 && y > 0)
{
    System.Console.WriteLine("Вы находитесь во второй четверти");
}
else if(x < 0 && y < 0)
{
    System.Console.WriteLine("Вы находитесь в третей четвети");
}
else if(x > 0 && y < 0)
{
    System.Console.WriteLine("Вы находитесь в четвертой четверти");
}
else
{
    System.Console.WriteLine("выши координаты находся на оси");
}
