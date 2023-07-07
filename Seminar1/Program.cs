//          Types
// int a = 25;

// double b = 36.6;

// string c = "Hello";

// bool d = true;

//      concatination and Formating

// int number1 = 5;
// int number2 = 7;
// Console.WriteLine(" my number " + number1 + " and " + number2 + " text  2 ");

// Console.WriteLine($" my number {number1} and {number2} text 2");

// Console.WriteLine("Hello, World!");

//      ВВод данных

//Запрос данных от пользователя
// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());


Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;
if(num1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("NO");
}
