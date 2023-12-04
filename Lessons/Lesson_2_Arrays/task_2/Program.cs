// найти в одномерном массиве значение равное find

int[] array = {12, 2, 32, 6, 4, 23, 43, 53};

int n = array.Length;//Lenght - возвращат длинну массива в n

int find = 43;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
    }
    index++;//index = inde + 1
}
