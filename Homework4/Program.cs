// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void step (int a, int b)
{
    Console.WriteLine($"{a}^{b} = {Math.Pow(a, b)}");
}

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

step(a, b);






// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number > 0)
{
    result += number % 10;
    number /= 10;
}

Console.WriteLine($"Сумма цифр в числе = {result}");





// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]



int[] NewArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(size + 1);
        Console.Write(myArray[i] + " ");
    }
    return myArray;
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] Array = NewArray(lenght);