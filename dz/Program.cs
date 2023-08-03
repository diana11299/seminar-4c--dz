//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
void Degree (int a, int b)
{
    if (b > 0)
    {
        int result = Convert.ToInt32(Math.Pow(a, b));
        Console.WriteLine(result);
    }
    else
    Console.WriteLine("Incorrect value" + b);
}    
Console.Write("Уnter the main degree: ");
int a = Convert.ToInt32(Console.ReadLine());        
Console.Write("enter exponent: ");
int b = Convert.ToInt32(Console.ReadLine());
Degree (a, b);
*/
//Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
/*
int SumNumbers(int N)
{
    int sum = 0;
    sum = sum + N % 10;
    N = N /10;
    if(N > 0)
    {
        sum += SumNumbers(N);
    }
    return sum ;
}
Console.WriteLine("Imput the number: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(s));
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);
*/