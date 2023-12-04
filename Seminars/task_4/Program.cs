// напишите программу, которая на вход принимает одно число (N), а на выходе покажет числа в промежутке от -N до N

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    System.Console.WriteLine("некорректный ввод!");
}

int index = -N;

while (index <= N)
{
    System.Console.Write(index + " ");
    index ++;
}
