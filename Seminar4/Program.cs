//напишите программу которая принимает на вход число А и выдает сумму от 1до А
/*


int Sum(int number)
{
    int count =0;
    int sum = 0;
    while (count < number)
    {
        sum += count;
        count++;
    }
    return sum;

}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
*/
//
/*
int Count(int number)
{
    int count = 0;
    while (number / 10 > 0)
    {
        number = number / 10;
        count ++;
    }
    return count;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("В вашем числе " + Count);


// 2

*/


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ")

    Consol.WriteLine();
}
Consol.Write("Input a Length: ");
int Length = Convert.ToInt32(Consol.ReadLine ())
{
    
}