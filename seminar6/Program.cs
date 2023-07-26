//напишите программу которая перевернет массив
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
//2.метод вывода массива на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void RevArray(int[]array)
{
    for(int i=0;i<array.Length/2;i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;

    }
    
}


Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение минимального элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение максимального элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(length, min, max);

ShowArray(myarray);
Console.WriteLine(" ");
RevArray(myarray);
ShowArray(myarray);
*/

//