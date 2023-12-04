// найти в одномерном массиве значение равное find
// заполняя массив рандомными числами

void FillArrey(int[] collection) // void метод который ничего не возвращает. нельзя использовать return
{
    int dlinna = collection.Lenght; // получаем длинну массива 
    int index = 0; //позиция в массиве. по умолчанию она начинается с 0
    while (index < dlinna) //цикл вайл, пока индекс меньше длинны массива
    {
        collection[index] = new Random().Next(1, 10); // на позицию index положить новое случайное число от 1 до 10
        index++; // index = index + 1
    }
}

void PrintArray(int[] col) //войд который будет печатать наш массив
{
    int count = col.Lenght;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[10];

FillArrey(array);
PrintArray(array);